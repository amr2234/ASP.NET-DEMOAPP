using CLS.DemoApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CLS.DemoApp.Web.Controllers
{
    public class BaseController : Controller
    {
        protected Client client;
        public BaseController()
        {
            var url = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build().GetSection("APISetting")["apiurl"];


            var x = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build().GetSection("APISetting")["x"];
            client = new Client(url);

        }

    }
}
