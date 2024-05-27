using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class ProductUpdateDto
    {

        public string Name { get; set; }
            public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

      
    }
}