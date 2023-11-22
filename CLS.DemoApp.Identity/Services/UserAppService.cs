using CLS.DemoApp.Identity.Contracts;
using CLS.DemoApp.Identity.Dtos;
using CLS.DemoApp.Identity.ExtendEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Identity.Services
{
    public class UserAppService: IUserAppService
    {
        private readonly UserManager<AppUser> usermanager;

        public UserAppService(UserManager<AppUser> usermanager)
        {
            this.usermanager = usermanager;
        }

        public async Task<bool> AddUser(UserDto obj)
        {

              var oldUser= await usermanager.FindByNameAsync(obj.UserName);
            if (oldUser != null)
            {
                AppUser user = new AppUser();
                user.UserName = obj.UserName;
                user.NationalNo = obj.NationalNo;
                var data = usermanager.CreateAsync(user, obj.Password);

                return true;
            }
            else
                return false;
        }
    }
}
