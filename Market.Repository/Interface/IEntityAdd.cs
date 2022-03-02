using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository.Interface
{
    public interface IEntityAdd<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        public abstract void Add(TEntity entity);
    }
}
