using DI_LINQ.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Entity
{
	public class App : IApp
	{
		private readonly IRepository<Employee> _employeeRepository;
		public App(IRepository<Employee> employeeRepository) 
		{
			_employeeRepository = employeeRepository;
		}
		public void Run()
		{
			Console.WriteLine("Im in Run()");
			var employees = new[]
			{
					new Employee { FirstName = "Jan", LastName = "Kowal" },
					new Employee { FirstName = "Ian", LastName = "Ferrer" },
					new Employee { FirstName = "John", LastName = "Smith" }
			};
			foreach (var employee in employees)
			{
				_employeeRepository.Add(employee);
			}

			_employeeRepository.Save();

			var gettingAllEmployees = _employeeRepository.GetAll();
			foreach (var emp in gettingAllEmployees)
			{
				Console.WriteLine(emp);
			}
		}
	}
}
