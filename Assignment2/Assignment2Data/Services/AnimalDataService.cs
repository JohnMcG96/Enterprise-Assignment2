using System;
using System.Collections.Generic;
using System.Text;
using Assignment2Data.Animal;
using Assignment2Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Assignment2Data.Services
{
    public class AnimalDataService : IAnimalDataService
    {
        private AnimalDBContext db = null;
        public AnimalDataService()
        {
            this.db = new AnimalDBContext();
        }
        public AnimalDataService(AnimalDBContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
            db.Initialise();
        }
        public IList<Animals> SelectAll()
        {
            return db.Animal.OrderBy(a => a.AniDoB).ToList();
        }
        public Animals SelectByID(int id)
        {
            return db.Animal.FirstOrDefault(c => c.AniId == id);
        }
        public Animals Insert(Animals obj)
        {
            db.Animal.Add(obj);
            db.SaveChanges();
            return obj;
        }
        public void Update(Animals obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
        public bool Delete(int id)
        {
            var existing = db.Animal.FirstOrDefault(c => c.AniId == id);
            if (existing == null)
            {
                return false;
            }
            db.Remove(existing);
            db.SaveChanges();
            return true;
        }
    }
}
