using Job.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Services.Models
{
    public class CartMusic
    {
        public int Quantity { get; set; }
        public Music Music { get; set; }
    }
}
