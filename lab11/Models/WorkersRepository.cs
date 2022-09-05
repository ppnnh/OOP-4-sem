using Lab_11.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.Models
{
    public class WorkersRepository : IRepository<Worker>
    {
        private MyDb db;
        public WorkersRepository(MyDb context)
        {
            this.db = context;
        }
        public IEnumerable<Worker> GetAll()
        {
            return db.Worker;
        }
        public Worker Get(int id)
        {
            return db.Worker.Find(id);
        }
        public void Create(Worker worker)
        {
            db.Worker.Add(worker);
        }
        public void Update(Worker worker)
        {
            db.Entry(worker).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Worker worker = db.Worker.Find(id);
            if(worker != null)
            {
                db.Worker.Remove(worker);
            }
        }
    }
}
