using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Entity
{
	public class Employee : EntityBase
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public override string ToString() => $"ID: {Id}, First Name: {FirstName}, Last Name: {LastName}";

	}
}
