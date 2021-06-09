using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop
{
    class Toy
    {
        [Key]
        public int id_toy { get; set; }
        public string article { get; set; }
        public string name { get; set; }
        public int? price { get; set; }
        public string category { get; set; }
        public int? height { get; set; }
        public int? width { get; set; }
        public string equipment { get; set; }
        public string material { get; set; }
        public string producing_country { get; set; }
        public string picture_small { get; set; }
        public string picture_big { get; set; }

        public Toy() { }

        public Toy(string article, string name,int? price,string category,int? height,int? width,string equipment,string material,string producing_country,string picture_small,string picture_big)
        {
            this.article = article;
            this.name = name;
            this.price = price;
            this.category = category;
            this.height = height;
            this.width = width;
            this.equipment = equipment;
            this.material = material;
            this.producing_country = producing_country;
            this.picture_small = picture_small;
            this.picture_big = picture_big;
        }
    }
}
