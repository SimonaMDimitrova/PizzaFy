namespace PizzaFy.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PizzaFy.Data.Common.Models;

    public class Town : BaseModel<string>
    {
        public Town()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public int PostalCode { get; set; }
    }
}
