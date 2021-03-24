using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPractic.Models
{
    public class Dish
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string View { get; set; }
        public Guid DishId { get; set; }

        private Dish dish;

        public Dish GetDish()
        {
            return dish;
        }

        public void SetDish(Dish value)
        {
            dish = value;
        }
    }
}
