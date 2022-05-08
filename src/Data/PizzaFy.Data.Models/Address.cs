namespace PizzaFy.Data.Models
{
    using System;
    using System.Collections.Generic;

    using PizzaFy.Data.Common.Models;

    public class Address : BaseDeletableModel<string>
    {
        public Address()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Orders = new HashSet<Order>();
        }

        public virtual Town Town { get; set; }

        public string TownId { get; set; }

        public string AddressInformation { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
