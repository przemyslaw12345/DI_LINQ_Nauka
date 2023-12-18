using DI_LINQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Repository
{
	public interface IReadRepository<out TEntity>
		where TEntity : class, IEntity
	{
		IEnumerable<TEntity> GetAll();
		TEntity GetId(int id);
	}
}
