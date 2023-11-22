
using CLS.DemoApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Entities
{
	public class SystemCode:Audit<int>
	{
     //   public int Id { get; set; }
        public  string Value { get; set; }
        public int TypeId { get; set; }
    }
}
