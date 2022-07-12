using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Data.Models.Domain
{
    public class Music
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int num_track { get; set; }
        public int duration { get; set; }
        public DateTime DateReleased { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
