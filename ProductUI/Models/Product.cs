using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductUI.Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int Price { get; set; }
        public string Vendor { get; set; }
    }
}
