using CLS.DemoApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CLS.DemoApp.Web.Controllers
{

	//[Route("/x")]
	public class GovernorateController : BaseController
	{
		public async Task<IActionResult> Index()
		{
		  var data = await client.GovernorateAllAsync();
			return View(data);
		}
	}
}
