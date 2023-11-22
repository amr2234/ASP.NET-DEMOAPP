
using CLS.DemoApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Entities
{
	public class PersonalData: FullAudit<int>
	{
       // public int Id { get; set; }

        public string FirstName { get; set; }
		public string SecondName { get; set; }

		
		public int VillageId { get; set; }

        public int RegTypeId { get; set; }
        public bool Active { get; set; }

		//public DateTime CreatedDate { get; set; }
	//	public DateTime LastModifiedDate { get; set; }


	}
}
