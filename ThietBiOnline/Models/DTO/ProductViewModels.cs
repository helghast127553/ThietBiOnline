using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DTO
{
    public class ProductViewModels
    {
        public List<Laptop> Laptops { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Tablet> Tablets { get; set; }
    }
}