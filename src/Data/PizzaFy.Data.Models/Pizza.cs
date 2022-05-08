namespace PizzaFy.Data.Models
{
    using PizzaFy.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Pizza : BaseDeletableModel<string>
    {
        public Pizza()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Cheeses = new HashSet<Cheese>();
            this.Meats = new HashSet<Meat>();
            this.Vegetables = new HashSet<Vegetable>();
        }

        public string Name { get; set; }

        public bool IsUserMade { get; set; }

        public virtual Dough Dough { get; set; }

        public string DoughId { get; set; }

        public virtual Sauce Sauce { get; set; }

        public string SauceId { get; set; }

        public virtual ICollection<Cheese> Cheeses { get; set; }

        public virtual ICollection<Meat> Meats { get; set; }

        public virtual ICollection<Vegetable> Vegetables { get; set; }
    }
}
