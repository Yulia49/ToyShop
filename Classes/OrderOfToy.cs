using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop
{
    class OrderOfToy
    {
        [Key]
        public int id_record { get; set; }
        public int? id_order { get; set; }
        public int? id_toy { get; set; }
        public int? quanity { get; set; }
        public OrderOfToy() { }
        public OrderOfToy(int? id_order, int? id_toy, int? quanity)
        {
            this.id_order = id_order;
            this.id_toy = id_toy;
            this.quanity = quanity;
        }
    }
}
