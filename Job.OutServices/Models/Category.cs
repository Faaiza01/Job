using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.OutServices.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Record[] Records { get; set; }
    }
}
