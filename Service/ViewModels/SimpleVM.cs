using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class SimpleVM
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Species { get; set; }

        public SimpleVM(Animal animal)
        {
            ID = animal.ID;
            Name = animal.Name;
            Species = animal.Species;
        }

        static List<SimpleVM> ConvertMany(List<Animal> animals)
        {
            List<SimpleVM> output = new List<SimpleVM>();
            foreach (var item in animals)
            {
                output.Add(new SimpleVM(item));
            }
            return output;
        }
    }
}
