using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repos
{
    public static class ReptileRepo
    {
        public static void Add(Reptile reptile)
        {
            using (ZooContext context = new ZooContext())
            {
                context.Reptiles.Add(reptile);
                context.SaveChanges();
            }
        }

        public static void Update(Reptile reptile)
        {
            Reptile entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Reptiles.Find(reptile.ID);
                context.Entry(entity).CurrentValues.SetValues(reptile);
                context.SaveChanges();
            }
        }

        public static Reptile Read(int id)
        {
            Reptile entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Reptiles.Find(id);
            }
            return entity;
        }

        public static List<Reptile> ReadAll()
        {
            List<Reptile> reptiles;
            using (ZooContext context = new ZooContext())
            {
                reptiles = context.Reptiles.ToList();
            }
            return reptiles;
        }

        public static void Delete(int id)
        {
            Reptile entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Reptiles.Find(id);
                context.Reptiles.Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
