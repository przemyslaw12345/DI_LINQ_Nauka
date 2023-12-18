using DI_LINQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Repository.RepositoryExtension
{
	public static class RepositoryExtension
	{
		public static void AddBatch<T>(this IRepository<T> repository, T[] items)
			where T : class, IEntity
		{
			foreach (var item in items)
			{
				repository.Add(item);
			}
			repository.Save();
		}
	}
}
