using CLS.DemoApp.Application.Contracts.Persistence;
using CLS.DemoApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Application.Contracts.Features
{
	public interface ICenterAppService: IAsyncRepository<CenterDTO>
	{
		public Task<List<CenterListDTO>> GetAllWithGovAsync();
	
	}
}
