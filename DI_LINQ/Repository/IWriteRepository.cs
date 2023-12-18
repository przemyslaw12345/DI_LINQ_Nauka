using DI_LINQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Repository
{
	public interface IWriteRepository<in TEntity>
		where TEntity : class, IEntity
	{
		void Add(TEntity entity);
		void Remove(TEntity entity);
		void Save();
	}
}
