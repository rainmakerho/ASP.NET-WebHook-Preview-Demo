using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebHookDemo.Sender.Providers
{
    public class ProductHookProvider : IWebHookFilterProvider
    {
        private readonly Collection<WebHookFilter> filters = new Collection<WebHookFilter>
        {
            new WebHookFilter { Name = "Add", Description = "Add Product happened."},
            new WebHookFilter { Name = "Update", Description = "Update Product happened."},
            new WebHookFilter { Name = "Delete", Description = "Delete Product happened."}
        };
        public Task<Collection<WebHookFilter>> GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }
    }
}