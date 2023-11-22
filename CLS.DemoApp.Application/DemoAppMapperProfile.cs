using AutoMapper;
using CLS.DemoApp.Application.Dtos;
using CLS.DemoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Application
{
	public class DemoAppMapperProfile:Profile
	{
        public DemoAppMapperProfile()
        {
            CreateMap<Governorate, GovernorateDTO>().ReverseMap();
            CreateMap<Center, CenterDTO>().ReverseMap();
		
		}
    }
}
