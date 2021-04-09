using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public int ID { get; set; }
        [Required]
<<<<<<< HEAD
        [Display(Name = "Category Name")]
=======
        [Display(Name="Category Name")]
>>>>>>> 4cc2b86d14f3582b54ec9081835a975de360afd4
        public string Name { get; set; }

        public IList<Cheese> Cheeses { get; set; }

        public CheeseCategory()
        {
        }
    }
}