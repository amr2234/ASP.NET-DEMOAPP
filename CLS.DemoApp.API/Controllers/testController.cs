using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLS.DemoApp.API.Controllers
{
	[Route("regapi/[controller]")]
	[ApiController]
	public class testController : ControllerBase
	{
		[HttpGet]
		public List<string> GetAll()
		{
			var data = new List<string>() { "aaa", "bb", "cc", "dd" };
			return data;
		}

	

		[HttpPost]
		public  string Postdata(string x)
		{
			
			return x;
		}
	}
}
