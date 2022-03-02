using Market.Domain;
using Market.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public abstract class BaseRepository<TEntity, Tkey> : MarketDbContext, IBaseRepository<TEntity, Tkey> where TEntity : BaseModel<Tkey>
    {
        private MarketDbContext _dbContext;
        private DbSet<TEntity> _entity;
        private string _connectionString;

        public BaseRepository(MarketDbContext dbContext)
        {
            _dbContext = dbContext;
            _entity = _dbContext.Set<TEntity>();
        }

        public BaseRepository(string connectionString) : base(connectionString)
        {
            this._connectionString = connectionString;
            _dbContext = new MarketDbContext(this._connectionString);
            _entity = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entity.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _entity.Remove(entity);
        }

        public void Delete(Tkey ID)
        {
            _entity.Remove(_entity.Find(ID));
        }

        public TEntity Get(Tkey ID)
        {
            return _entity.Find(ID);
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public void Update(TEntity delete, TEntity update)
        {
            _entity.Remove(delete);
            _entity.Add(update);
        }
    }
}
