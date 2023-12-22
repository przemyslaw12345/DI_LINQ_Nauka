using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DI_LINQ.Entity;
using Microsoft.Extensions.Options;

namespace DI_LINQ.Data
{
	public class SilaGenerycznosciDbContext : DbContext
	{
		public DbSet<Employee> Employees => Set<Employee>();
		public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

        public SilaGenerycznosciDbContext(DbContextOptions<SilaGenerycznosciDbContext> option) : base(option)
		{
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
		{
			base.OnConfiguring(optionsbuilder);
			//optionsbuilder.UseInMemoryDatabase("StorageApp"); // making a database with efc as we are using in memory storage need to implement it with this code
		}
	}
}

