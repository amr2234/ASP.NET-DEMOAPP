using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Identity.ExtendEntities
{
    public class AppUser:IdentityUser
    {
        public string? NationalNo { get; set; }
    }
}
