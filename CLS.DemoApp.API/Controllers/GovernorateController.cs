using CLS.DemoApp.Application.Contracts.Features;
using CLS.DemoApp.Application.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLS.DemoApp.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GovernorateController : ControllerBase
	{
		IGovernorateAppService GovAppservice;

		public GovernorateController(IGovernorateAppService GovAppservice)
        {
			this.GovAppservice = GovAppservice;
        }

        [HttpGet]
		public async Task<List<GovernorateDTO>> GetGovernorates()
		{
			var data = await GovAppservice.GetAllAsync();
			return data;

		}
		[HttpPost]
		public async Task<GovernorateDTO> PostGovernorate(GovernorateDTO Obj)
		{
			var data = await GovAppservice.AddAsync(Obj);
			return data;

		}
	}
}
