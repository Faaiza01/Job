using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.OutServices.Models
{
    public class Record
    {
        public Record() {}
        public Record(int id, string title, double price, string released)
        {
            ID = id; Title = title;
            Price = price; Released = released;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Released { get; set; }
    }
}
