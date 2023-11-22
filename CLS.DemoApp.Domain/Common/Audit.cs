using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Domain.Common
{
	public class Audit<T>
	{
		public T Id { get; set; }
	}
}
