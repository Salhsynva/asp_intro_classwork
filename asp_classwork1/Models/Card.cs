using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_classwork1.Models
{
    public class Card
    {
        public Card(int id, string name,string description,  string image, double price)
        {
            this.Id = id;
            this.Image = image;
            this.Price = price;
            this.Description = description;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
    }
}
