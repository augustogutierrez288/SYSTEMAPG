using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SYSTEMAPG.DAL.DBContext;
using SYSTEMAPG.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SYSTEMAPG.DAL.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly SYSTEMAPGContext _context;

        public GenericRepository(SYSTEMAPGContext context)
        {
            _context = context;
        }
        public async Task<TEntity> Obtain(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                TEntity entity = await _context.Set<TEntity>().FirstOrDefaultAsync(filter);
                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> Update(TEntity entity)
        {
            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> Delete(TEntity entity)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<IQueryable<TEntity>> Consult(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> queryEntity = filter == null ? _context.Set<TEntity>() : _context.Set<TEntity>().Where(filter);
            return queryEntity;
        }
    }
}
