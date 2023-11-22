using CLS.DemoApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CLS.DemoApp.Web.Controllers
{
    public class GovController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult DisplayList(int jtStartIndex = 0, int jtPageSize = 0, string jtSorting = null,string govname=null)
        {
            try
            
            {
                var data =  client.GovernorateAllAsync().Result;
               

                if(govname!=null)
                {
                    data = data.Where(a=>a.GovName.Contains(govname)).ToList();
                }
               
                return Json(new { Result = "OK", Records = data.Skip(jtStartIndex).Take(jtPageSize).ToList(), TotalRecordCount = data.Count }
                , new System.Text.Json.JsonSerializerOptions());
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }




        [HttpPost]
        public JsonResult Create(GovernorateDTO obj)
        {
            try
            {
                var addedObj = client.GovernorateAsync(obj).Result;
                return Json(new { Result = "OK", Record = addedObj }, new System.Text.Json.JsonSerializerOptions());
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}
