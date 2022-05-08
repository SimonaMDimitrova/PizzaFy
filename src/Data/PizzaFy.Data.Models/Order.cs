namespace PizzaFy.Data.Models
{
    using System;
    using System.Collections.Generic;

    using PizzaFy.Data.Common.Models;

    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Pizzas = new HashSet<Pizza>();
        }

        public string Name { get; set; }

        public virtual Address Address { get; set; }

        public string AddressId { get; set; }

        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
