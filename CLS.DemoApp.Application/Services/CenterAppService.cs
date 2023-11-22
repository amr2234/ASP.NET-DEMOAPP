using AutoMapper;
using CLS.DemoApp.Application.Contracts.Features;
using CLS.DemoApp.Application.Contracts.Persistence;
using CLS.DemoApp.Application.Dtos;
using CLS.DemoApp.Application.Helpers;
using CLS.DemoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Application.Services
{
	public class CenterAppService : ICenterAppService
	{
		IAsyncRepository<Center> rep;
		IAsyncRepository<Governorate> Govrep;
		IMapper mapper;
		public CenterAppService(IAsyncRepository<Center> myrep, IAsyncRepository<Governorate> Govrep, IMapper mapper)
        {
			rep = myrep;
			this.mapper = mapper;
			this.Govrep = Govrep;

		}
        public async Task<CenterDTO> AddAsync(CenterDTO Obj)
		{

			var data = mapper.Map<Center>(Obj);
			var newObj= await rep.AddAsync(data);
			MailManager.sendMail("aaa", "aaaaaaaaa");

            return mapper.Map<CenterDTO>(newObj);


		}

		public Task<CenterDTO> DeleteAsync(CenterDTO Obj)
		{
			throw new NotImplementedException();
		}

		public Task<CenterDTO> DeleteAsync(int ID)
		{
			throw new NotImplementedException();
		}

		public async Task<List<CenterDTO>> GetAllAsync()
		{
			var data =await rep.GetAllAsync();
			return mapper.Map<List<CenterDTO>>(data);
		}

		public async Task<List<CenterListDTO>> GetAllWithGovAsync()
		{
			var data = await rep.GetAllAsync();
			var finaldata = data.Join(Govrep.GetAllAsync().Result, a => a.GovernorateId, b => b.Id, (a, b) => new CenterListDTO { Id = a.Id, CenterName = a.CenterName, GovName = b.GovName });
			return  finaldata.ToList();
		}

		public Task<CenterDTO> GetByIDAsync(int ID)
		{
			throw new NotImplementedException();
		}

		public Task<CenterDTO> UpdateAsync(CenterDTO Obj)
		{
			throw new NotImplementedException();
		}
	}
}
