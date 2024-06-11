using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;

namespace SYSTEMAPG.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Obtain(Expression<Func<TEntity, bool>> filter);
                
        Task<TEntity> Create(TEntity entity);
       
        Task<bool> Update(TEntity entity);
               
        Task<bool> Delete(TEntity entity);
      
        Task<IQueryable<TEntity>> Consult(Expression<Func<TEntity, bool>> filter = null);
    }
}
