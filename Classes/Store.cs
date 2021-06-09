using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop
{
    class Store
    {
        [Key]
        public int id_record { get; set; }
        public int? id_toy { get; set; }
        public int quantity { get; set; }
        public string location { get; set; }
        public DateTime? nearest_date_of_supply { get; set; }

        public Store() { }

        public Store(int? id_toy, int quantity, string location, DateTime? nearest_date_of_supply)
        {
            this.id_toy = id_toy;
            this.quantity = quantity;
            this.location = location;
            this.nearest_date_of_supply = nearest_date_of_supply;
        }
    }
}
