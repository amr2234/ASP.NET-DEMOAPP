using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Common
{
	public class FullAudit<DT> : Audit<DT>
	{
		public DateTime? CreatedDate { get; set; }
		public DateTime? LastModifiedDate { get; set; }
	}
}
