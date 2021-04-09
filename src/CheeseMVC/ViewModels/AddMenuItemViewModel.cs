using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
<<<<<<< HEAD
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }


        public int CheeseID { get; set; }
        public int MenuID { get; set; }

        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {

=======
        public int CheeseID { get; set; }
        public int MenuID { get; set; }

        public Menu Menu { get; set; }

        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel (Menu menu, IEnumerable<Cheese> cheeses)
        {
>>>>>>> 4cc2b86d14f3582b54ec9081835a975de360afd4
            Cheeses = new List<SelectListItem>();

            foreach (var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }
<<<<<<< HEAD

            Menu = menu;
        }
    }

}
=======
            Menu = menu;
        }
        public AddMenuItemViewModel()
        {

        }
    }
}
>>>>>>> 4cc2b86d14f3582b54ec9081835a975de360afd4
