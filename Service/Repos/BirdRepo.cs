using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repos
{
    public static class BirdRepo
    {
        public static void Add(Bird bird)
        {
            using (ZooContext context = new ZooContext())
            {
                context.Birds.Add(bird);
                context.SaveChanges();
            }
        }

        public static void Update(Bird bird)
        {
            Bird entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Birds.Find(bird.ID);
                context.Entry(entity).CurrentValues.SetValues(bird);
                context.SaveChanges();
            }
        }

        public static Bird Read(int id)
        {
            Bird entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Birds.Find(id);
            }
            return entity;
        }

        public static List<Bird> ReadAll()
        {
            List<Bird> birds;
            using (ZooContext context = new ZooContext())
            {
                birds = context.Birds.ToList();
            }
            return birds;
        }

        public static void Delete(int id)
        {
            Bird entity;
            using (ZooContext context = new ZooContext())
            {
                entity = context.Birds.Find(id);
                context.Birds.Remove(entity);
                context.SaveChanges();
            }
        }

    }
}
