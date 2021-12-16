using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repos
{
    public static class MamalRepo
    {
        public static void Add(Mamal mamal)
        {
            using (ZooContext context = new ZooContext())
            {
                context.Mamals.Add(mamal);
                context.SaveChanges();
            }
        }

        public static void Update(Mamal mamal)
        {
            Mamal entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Mamals.Find(mamal.ID);
                context.Entry(entity).CurrentValues.SetValues(mamal);
                context.SaveChanges();
            }
        }

        public static Mamal Read(int id)
        {
            Mamal entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Mamals.Find(id);
            }
            return entity;
        }

        public static List<Mamal> ReadAll()
        {
            List<Mamal> mamals;
            using (ZooContext context = new ZooContext())
            {
                mamals = context.Mamals.ToList();
            }
            return mamals;
        }

        public static void Delete(int id)
        {
            Mamal entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Mamals.Find(id);
                context.Mamals.Remove(entity);
                context.SaveChanges();
            }            
        }

        
    }
}
