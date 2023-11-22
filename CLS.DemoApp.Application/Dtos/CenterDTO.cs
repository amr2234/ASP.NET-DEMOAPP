using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Application.Dtos
{
	public class CenterDTO
	{
		public int Id { get; set; }
		public string CenterName { get; set; }
	
		public int GovernorateId { get; set; }
	}
}
