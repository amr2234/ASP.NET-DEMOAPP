
using CLS.DemoApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Entities
{
	public class SystemCodeType:Audit<int>
	{

      //  public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
