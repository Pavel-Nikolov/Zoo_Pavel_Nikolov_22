using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Mamal : Animal
    {
        public bool IsPregnant { get; set; }

        public Mamal() : base()
        {

        }
    }
}
