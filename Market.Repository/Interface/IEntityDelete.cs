using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository.Interface
{
    public interface IEntityDelete<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        public abstract void Delete(TEntity entity);

        public abstract void Delete(TKey ID);
    }
}
