namespace PizzaFy.Data.Models
{
    using System;

    using PizzaFy.Data.Common.Models;

    public class Fruit : BaseDeletableModel<string>
    {
        public Fruit()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
