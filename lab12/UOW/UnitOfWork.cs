using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_LAB_12.Classes;
using OOP_LAB_12.Repository;

namespace OOP_LAB_12.UOW
{
    public class UnitOfWork<TEntity> : IDisposable where TEntity : class
    {
        private Context.Context _context = new Context.Context();
        private CrudRepository<TEntity> crudRepository;

        public CrudRepository<TEntity> CrudRepository => crudRepository ?? (crudRepository = new CrudRepository<TEntity>(_context));


        public void Save()
        {
            bool isSaved;
            do
            {
                isSaved = true;
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    isSaved = false;
                    e.Entries.Single().Reload();
                }
            } while (isSaved);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
