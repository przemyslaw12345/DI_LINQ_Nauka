using DI_LINQ.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LINQ.Repository
{
	public class SQLRepository<TEntity> :
		IRepository<TEntity> where TEntity : class, IEntity, new()
	{
		private readonly DbSet<TEntity> _dbSet;
		private readonly DbContext _dbContext;

		// private readonly ItemAdded<TEntity>? _itemAddedCallback;
		private readonly Action<TEntity>? _itemAddedCallback;

		public SQLRepository(DbContext dbContext,
			Action<TEntity>? itemAddedCallback = null
			/*ItemAdded<TEntity>? itemAddedCallback=null*/)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<TEntity>();
			_itemAddedCallback = itemAddedCallback;
		}
		public event EventHandler<TEntity>? ItemAdded; //creates an event using EventHandler

		public IEnumerable<TEntity> GetAll()
		{
			return _dbSet.ToList();
		}
		public TEntity GetId(int Id)
		{
			return _dbSet.Find(Id);
		}
		public void Add(TEntity item)
		{
			_dbSet.Add(item);
			_itemAddedCallback?.Invoke(item);
			ItemAdded?.Invoke(this, item); // invokes the event from this location with inserted item
		}
		public void Remove(TEntity item)
		{
			_dbSet.Remove(item);
		}
		public void Save()
		{
			_dbContext.SaveChanges();
		}
	}
}
