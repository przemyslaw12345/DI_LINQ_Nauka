using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DI_LINQ.Entity;

namespace DI_LINQ.Data
{
	internal class SilaGenerycznosciDbContext : DbContext
	{
		public DbSet<Employee> Employees => Set<Employee>();
		public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseInMemoryDatabase("StorageApp"); // making a database with EFC as we are using in memory storage need to implement it with this code
		}
	}
}

