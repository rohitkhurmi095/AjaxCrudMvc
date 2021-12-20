using ClothBazar.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
    //CBDbContext:DbContext
    //DbContext contains methods to query Db
    //--------------------------------------
    public class CBDbContext:DbContext
    {
        //Passing Connectiong string to DbContext
        //---------------------------------------
        public CBDbContext():base("ClothBazarDb")
        {

        }

        //DbSets - Tables in Database
        //----------------------------
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
