using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD

=======
>>>>>>> 4cc2b86d14f3582b54ec9081835a975de360afd4
namespace CheeseMVC.Models
{
    public class Menu
    {
        public int ID { get; set; }


        public string Name { get; set; }

        public IList<CheeseMenu> CheeseMenus { get; set; } = new List<CheeseMenu>();
    }
}