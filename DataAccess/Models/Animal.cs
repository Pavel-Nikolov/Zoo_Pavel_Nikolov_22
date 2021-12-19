using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    [Index(nameof(Name))]
    [Index(nameof(Species))]
    
    //The base class for the other modes
    public abstract class Animal
    {
        [Key]
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Range(1,int.MaxValue)]
        public int EnclosureNumber { get; set; }
        [Range(1, int.MaxValue)]
        public int Age { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Species { get; set; }
        [EnumDataType(typeof(TempreturePreference))]
        public TempreturePreference TempreturePreference { get; set; }
        public Animal()
        {

        }
    }
}
