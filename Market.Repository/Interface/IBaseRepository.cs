using Market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository.Interface
{
    //დაამატო, დაარედაქტირო, წაშალო და ამოიკითხო პროდუქტები,
    public interface IBaseRepository<TEntity, TKey> : IEntityAdd<TEntity, TKey>, 
        IEntityGet<TEntity, TKey>,
        IEntityDelete<TEntity, TKey>,
        IEntityUpdate<TEntity, TKey>
        where TEntity : BaseModel<TKey>
    {

    }
}
