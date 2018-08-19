using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavesList.Models
{
    public class RetailerCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int RetailerId { get; set; }
    }
}
