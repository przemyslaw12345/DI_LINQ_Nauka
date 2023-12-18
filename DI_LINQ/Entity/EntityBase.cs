using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Entity
{
	public abstract class EntityBase : IEntity
	{
		public int Id { get; set; }
	}
}
