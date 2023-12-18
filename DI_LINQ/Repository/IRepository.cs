using DI_LINQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Repository
{
	public interface IRepository<TEntity> :
		IReadRepository<TEntity>,
		IWriteRepository<TEntity>
		where TEntity : class, IEntity
	{
	}
}
