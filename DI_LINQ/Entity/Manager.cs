using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Entity
{
	internal class Manager : Employee
	{
		public override string ToString() => base.ToString() + " (Manager)";
	}
}
