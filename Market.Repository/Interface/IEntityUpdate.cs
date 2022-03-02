using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository.Interface
{
    public interface IEntityUpdate<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        public abstract void Update(TEntity delete, TEntity update);
    }
}
