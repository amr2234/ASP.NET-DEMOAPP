
using CLS.DemoApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Entities
{
	public class Governorate:FullAudit<int>
	{
      //  public int Id { get; set; }
        public string? GovName { get; set; }
        //  public DateTime CreatedDate { get; set; }
        //public DateTime LastModifiedDate { get; set; }
        public string? LogoName { get; set; }

    }
}
