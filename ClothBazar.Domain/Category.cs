using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Domain
{
    //Category
    //=========
    public class Category:BaseEntity
    {

        //Navigation Property
        //-------------------
        //1 Category: Multiple Products
        public virtual ICollection<Product> Products { get; set; }
    }
}
