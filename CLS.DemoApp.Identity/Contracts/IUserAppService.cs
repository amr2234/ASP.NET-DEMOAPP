using CLS.DemoApp.Identity.Dtos;
using CLS.DemoApp.Identity.ExtendEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Identity.Contracts
{
    public interface IUserAppService
    {

        public Task<bool> AddUser(UserDto obj);
    }
}
