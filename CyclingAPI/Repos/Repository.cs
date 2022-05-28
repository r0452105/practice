using CyclingAPI.Data;
using CyclingAPILib;
using CyclingAPILib.Interface;
using Microsoft.EntityFrameworkCore;

namespace CyclingAPI.Repos
{
    public class Repository : ICyclistRepo

    {
        protected readonly CyclingAPIContext _dbContext;

        public Repository(CyclingAPIContext ctx)
        {
            _dbContext = ctx;
        }

        public virtual async Task<IEnumerable<Cyclist>> GetAll()
        {
            return await _dbContext.Set<Cyclist>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<Cyclist> GetById(int id)
        {
            return await _dbContext.Set<Cyclist>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<Cyclist> Create(Cyclist entity)
        {
            _dbContext.Set<Cyclist>().Add(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }

        public virtual async Task<Cyclist> Delete(Cyclist entity)
        {
            _dbContext.Set<Cyclist>().Remove(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }

        public virtual async Task<Cyclist> DeleteById(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return null;
            }
            return await Delete(entity);
        }

        public virtual async Task<Cyclist> Update(Cyclist entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }
    }
}