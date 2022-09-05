using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OOP_LAB_12.Repository
{
    interface ICrudRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        void ReadSmartphone(DataGrid dataGrid);
    }
}