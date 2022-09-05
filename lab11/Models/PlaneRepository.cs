﻿using Lab_11.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.Models
{
    public class PlaneRepository : IRepository<Plane>
    {
        private MyDb db;
        public PlaneRepository(MyDb context)
        {
            this.db = context;
        }
        public IEnumerable<Plane> GetAll()
        {
            return db.Plane;
        }
        public Plane Get(int id)
        {
            return db.Plane.Find(id);
        }
        public void Create(Plane worker)
        {
            db.Plane.Add(worker);
        }
        public void Update(Plane worker)
        {
            db.Entry(worker).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Plane worker = db.Plane.Find(id);
            if (worker != null)
            {
                db.Plane.Remove(worker);
            }
        }
    }
}
