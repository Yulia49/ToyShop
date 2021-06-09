using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop
{
    class Employee
    {
        [Key]
        public int id_employee { get; set; }
        public string name { get; set; }
        public int? age { get; set; }
        public string phone { get; set; }
        public int? salary { get; set; }
        public string pass { get; set; }
        public string position { get; set; }
        public string email { get; set; }
        public string employeelogin { get; set; }

        public Employee()
        { }

        public Employee(string name, int? age, string phone, int? salary, string pass, string position, string email, string employeelogin)
        {
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.salary = salary;
            this.pass = pass;
            this.position = position;
            this.email = email;
            this.employeelogin = employeelogin;
        }
    }
}
