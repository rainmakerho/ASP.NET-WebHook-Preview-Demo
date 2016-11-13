using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WebHookDemo.Sender.Models;

namespace WebHookDemo.Sender.Controllers
{
    [Authorize]
    public class ProductsController : ApiController
    {
        static List<Product> _Products = new List<Product>()
        {
            new Product {Id=1, Name="RADAR", Price=1000M , Description="人事系統"},
            new Product {Id=2, Name="RMTECH", Price=2010M , Description="RM系統"}
        };

        // GET api/Products
        public IEnumerable<Product> Get()
        {
            return _Products;
        }

        // GET api/Products/1
        public IHttpActionResult Get(int id)
        {
            var product = _Products
                            .Where(p => p.Id == id)
                            .FirstOrDefault();
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // POST api/Products
        public async Task Post([FromBody]Product product)
        {
            if (product != null)
            {
                var newProductId = _Products.Max(p => p.Id) + 1;
                product.Id = newProductId;
                product.Description += DateTime.Now.ToString("hh:mm:ss");
                _Products.Add(product);
                await this.NotifyAsync("Add", new { Product = product });
            }

        }

        // PUT api/Products/1
        public async Task Put(int id, [FromBody]Product product)
        {
            _Products.RemoveAll(p => p.Id == id);
            product.Description += DateTime.Now.ToString("hh:mm:ss");
            _Products.Add(product);
            await this.NotifyAsync("Update", new { Product = product });
        }

        // DELETE api/values/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            var product = _Products
                            .Where(p => p.Id == id)
                            .FirstOrDefault();
            if (product == null)
                return NotFound();
            product.Description += DateTime.Now.ToString("hh:mm:ss");
            await this.NotifyAsync("Delete", new { Product = product });
            return Ok();
        }
    }
}