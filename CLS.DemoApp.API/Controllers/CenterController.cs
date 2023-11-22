using CLS.DemoApp.Application.Contracts.Features;
using CLS.DemoApp.Application.Dtos;
using CLS.DemoApp.Application.Services;
using CLS.DemoApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLS.DemoApp.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class CenterController : ControllerBase
	{
		ICenterAppService CenterAppservice;

		public CenterController(ICenterAppService CenterAppservice)
		{
			this.CenterAppservice = CenterAppservice;
		}

		[HttpGet]
		public async Task<List<CenterDTO>> GetCenters()
		{
			var data = await CenterAppservice.GetAllAsync();
			return data;

		}
		[HttpGet]
		public async Task<List<CenterListDTO>> GetCentersWithGov()
		{
			var data = await CenterAppservice.GetAllWithGovAsync();
			return data;

		}
		[HttpPost]
		public async Task<CenterDTO> AddCenter(CenterDTO Obj)
		{
			var data = await CenterAppservice.AddAsync(Obj);
			return data;

		}



	}
}
