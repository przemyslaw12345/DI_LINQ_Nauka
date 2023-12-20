
using DI_LINQ.Data;
using DI_LINQ.Entity;
using DI_LINQ.Repository;
using DI_LINQ.Repository.RepositoryExtension;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton <IRepository<Employee>, SQLRepository<Employee>>();
services.AddDbContext<SilaGenerycznosciDbContext>(option => option.UseInMemoryDatabase("StorageApp"));

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>()!;
app.Run();

Console.ReadKey();
//var sqlRepository = new SQLRepository<Employee>(new SilaGenerycznosciDbContext(), EmployeeAdded /*itemAdded*/);
//sqlRepository.ItemAdded += SQLRepositoryOnItemAdded;


//AddEmployee(sqlRepository);
//ReadAll(sqlRepository);

//Console.ReadKey();

//void SQLRepositoryOnItemAdded(object? sender, Employee e)
//{
//	Console.WriteLine($"{e.FirstName} added from {sender.GetType().Name}");
//}
//static void EmployeeAdded(Employee item)
//{
//	Console.WriteLine($"{item.FirstName} added");
//}
//void AddEmployee(IRepository<Employee> employeeRepository)
//{
//	var employees = new[]
//	{
//		new Employee { FirstName = "Jan", LastName = "Kowal" },
//		new Employee { FirstName = "Ian", LastName = "Ferrer" },
//		new Employee { FirstName = "John", LastName = "Smith" }
//	};
//	employeeRepository.AddBatch(employees);
//	//employeeRepository.Add(new Employee { FirstName = "Jan", LastName = "Kowal" });
//	//employeeRepository.Add(new Employee { FirstName = "Ian", LastName = "Ferrer" });
//	//employeeRepository.Add(new Employee { FirstName = "John", LastName = "Smith" });
//	//employeeRepository.Save();
//}


//void ReadAll(IReadRepository<IEntity> sqlRepository)
//{
//	var items = sqlRepository.GetAll();
//	foreach (var item in items)
//	{
//		Console.WriteLine(item.ToString());
//	}
//}
