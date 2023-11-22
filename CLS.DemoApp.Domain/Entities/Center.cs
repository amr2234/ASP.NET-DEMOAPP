
using CLS.DemoApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Entities
{

	[Table("LK_Center")]
	public class Center: FullAudit<int>
	{
	//	public int Id { get; set; }

		[Required]
		[StringLength(50)]
		[Column("CenterName")]
		public string CenterName { get; set; }
	   //	public DateTime CreatedDate { get; set; }
		//public DateTime LastModifiedDate { get; set; }

		[ForeignKey("Governorate")]
		public int GovernorateId { get; set; }




		//[ForeignKey("GovernorateId")]
		public Governorate Governorate { get; set; }




    }
}
