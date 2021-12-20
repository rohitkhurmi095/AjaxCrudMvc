using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothBazar.Web.Models.Dto_s
{
    //To Solve Circular Dependency 
    //Create Dto + get Categories data -> Dto + convert to List()
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}