using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Domain
{
    //Product
    //========
    public class Product:BaseEntity
    {
        //Price
        public decimal Price { get; set; }

        //ForeignKey
        public int CategoryId { get; set; }

        //Navigation Property
        //--------------------
        //1Product:1Category
        public virtual Category Category { get; set; }
    }
}
