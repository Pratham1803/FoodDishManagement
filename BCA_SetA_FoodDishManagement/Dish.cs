using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_SetA_FoodDishManagement
{
    internal class Dish
    {
        public int Id { get; set; }
        public int dishId { get; set; }
        public string dishName { get; set; }
        public int calories { get; set;}
        public int price { get; set; }
        public string isLowFat { get; set; }
    }
}
