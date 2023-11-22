using CLS.DemoApp.Application.Contracts.Features;
using CLS.DemoApp.Application.Contracts.Persistence;
using CLS.DemoApp.Application.Dtos;
using CLS.DemoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace CLS.DemoApp.Application.Services
{
	public class GovernorateAppService : IGovernorateAppService
	{
		IAsyncRepository<Governorate> rep;
		IMapper mapper;
		public GovernorateAppService(IAsyncRepository<Governorate> rep, IMapper mapper)
        {
			this.rep = rep;
			this.mapper = mapper;
        }
        public async Task<GovernorateDTO> AddAsync(GovernorateDTO Obj)
		{
			//Governorate gov = new Governorate();
			//gov.GovName = Obj.GovName;
			//gov.LogoName = Obj.LogoName;

		    var gov=mapper.Map<Governorate>(Obj);
			   var data= await rep.AddAsync(gov);
			return mapper.Map<GovernorateDTO>(data);
			//Obj.Id = data.Id;
			//Obj.GovName = data.GovName;
			//Obj.LogoName = data.LogoName;
			//return Obj;


		}

		public Task<GovernorateDTO> DeleteAsync(GovernorateDTO Obj)
		{
			throw new NotImplementedException();
		}

		public Task<GovernorateDTO> DeleteAsync(int ID)
		{
			throw new NotImplementedException();
		}

		public async Task<List<GovernorateDTO>> GetAllAsync()
		{
			var data = await rep.GetAllAsync();
			return mapper.Map<List<GovernorateDTO>>(data);
		}

		public Task<GovernorateDTO> GetByIDAsync(int ID)
		{
			throw new NotImplementedException();
		}

		public Task<GovernorateDTO> UpdateAsync(GovernorateDTO Obj)
		{
			throw new NotImplementedException();
		}
	}
}
