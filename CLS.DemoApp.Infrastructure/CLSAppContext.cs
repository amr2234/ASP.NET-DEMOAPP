using CLS.DemoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Infrastructure
{
	public class CLSAppContext:DbContext
	{
		public CLSAppContext(DbContextOptions ops) : base(ops)
		{

		}
		public DbSet<SystemCodeType> SystemCodeTypes { get; set; }
		public DbSet<SystemCode> SystemCodes { get; set; }

		public DbSet<Governorate> Governorates { get; set; }

		public DbSet<Center> Centers { get; set; }

		public DbSet<Village> Villages { get; set; }
		public DbSet<PersonalData> PersonalData { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //	optionsBuilder.UseSqlServer("server=.;database=CLSDemoRegdb;Integrated Security=true");
        //}

    

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var entry in ChangeTracker.Entries())
            {
                
                if(entry.Properties.Any(a=>a.Metadata.Name== "CreatedDate") && entry.State==EntityState.Added)
                {

                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                    if (string.IsNullOrEmpty(entry.Property("LogoName").CurrentValue?.ToString()))
                    { 
                       entry.Property("LogoName").CurrentValue = "photo.png";
                    }
                }

                if (entry.Properties.Any(a => a.Metadata.Name == "LastModifiedDate") && entry.State == EntityState.Modified)
                {
                    entry.Property("LastModifiedDate").CurrentValue = DateTime.Now;

                }

            }


            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
