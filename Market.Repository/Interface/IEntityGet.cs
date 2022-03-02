using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Market.Repository.Interface
{
     public interface IEntityGet<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        public abstract TEntity Get(TKey ID);

        public abstract IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
    }
}
