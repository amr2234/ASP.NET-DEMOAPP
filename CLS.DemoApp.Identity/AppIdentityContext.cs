using CLS.DemoApp.Identity.ExtendEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Identity
{
    public class AppIdentityContext:IdentityDbContext<AppUser>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CLSDemoRegdb;Integrated Security=true");
        }

    }
}
