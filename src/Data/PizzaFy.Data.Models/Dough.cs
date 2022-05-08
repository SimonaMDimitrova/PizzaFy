namespace PizzaFy.Data.Models
{
    using System;

    using PizzaFy.Data.Common.Models;

    public class Dough : BaseDeletableModel<string>
    {
        public Dough()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
