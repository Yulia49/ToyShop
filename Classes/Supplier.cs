using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop
{
    class Supplier
    {
        [Key]
        public int id_supplier { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public Supplier() { }
        public Supplier(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
    }
}
