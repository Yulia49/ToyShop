using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop
{
    class Order
    {
        [Key]
        public int id_order { get; set; }
        public int? id_employee { get; set; }
        public DateTime date_of_order { get; set; }

        public Order() { }

        public Order (int? id_employee, DateTime date_of_order)
        {
            this.id_employee = id_employee;
            this.date_of_order = date_of_order;
        }
    }
}
