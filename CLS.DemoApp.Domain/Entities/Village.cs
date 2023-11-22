using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CLS.DemoApp.Domain.Common;

namespace CLS.DemoApp.Domain.Entities
{
	public class Village: FullAudit<int>
	{
		//public int Id { get; set; }

		public string VillageName { get; set; }
	//	public DateTime CreatedDate { get; set; }
	//	public DateTime LastModifiedDate { get; set; }

        public int CenterId { get; set; }

        public Center Center { get; set; }

    }
}
