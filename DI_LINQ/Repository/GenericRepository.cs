using DI_LINQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Repository
{
	public class GenericRepository<TEntity> :
		IRepository<TEntity> where TEntity : class, IEntity, new() // TEntity must be a class that inherits from IEntity and contain a parameterless Constructor
	{
		public List<TEntity> _item = new List<TEntity>();

		public IEnumerable<TEntity> GetAll()
		{
			return _item.ToList();
		}
		public void Add(TEntity item)
		{
			item.Id = _item.Count + 1;
			_item.Add(item);
		}
		public TEntity GetId(int id)
		{
			return _item.Single(item => item.Id == id);
		}
		public void Save()
		{
			//foreach (TEntity item in _item)
			//{
			//	Console.WriteLine(item);
			//}
		}
		public void Remove(TEntity item)
		{
			_item.Remove(item);
		}
	}
}
