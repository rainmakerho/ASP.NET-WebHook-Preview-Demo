using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebHookDemo.Receiver.Handlers
{
    public class ProductHookHandler : WebHookHandler
    {
         
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            //Id為product的才進來處理
            if (context?.Id != "product")
                return Task.FromResult(true);

            // Get data from WebHook
            CustomNotifications data = context.GetDataOrDefault<CustomNotifications>();

            // 如果這裡會處理太久的話，建議將資料放到 Queue 之中慢慢處理，先回傳 true 
            //https://docs.asp.net/projects/webhooks/en/latest/receiving/handlers.html
            // Get data from each notification in this WebHook
            foreach (IDictionary<string, object> notification in data.Notifications)
            {
                var action = notification["Action"];
                JObject product = (JObject)notification["Product"];
            }
            return Task.FromResult(true);
        }
    }
}