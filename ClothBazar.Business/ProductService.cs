using ClothBazar.Business.Interfaces;
using ClothBazar.Database;
using ClothBazar.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Business
{
    public class ProductService : IProductService
    {
        //DbContext instance
        //-------------------
        private CBDbContext db = new CBDbContext();


        //Add new Product
        //===============
        public void Add(Product product)
        {
            //Add Product to db + saveChanges()
            db.Products.Add(product);
            db.SaveChanges();
        }


        //Get All Products
        //=================
        public List<Product> GetAll()
        {
            //Products list
            return db.Products.ToList();
        }


        //Get Product by Id
        //==================
        public Product GetById(int Id)
        {
            //Find Product by Id
            return db.Products.Find(Id);
        }


        //Remove Product
        //===============
        public void Remove(int Id)
        {
            //Find Product by Id
            var product = GetById(Id);

            //Remove product + saveChanges()
            db.Products.Remove(product);
            db.SaveChanges();

        }


        //Update Product
        //===============
        public void Update(Product product)
        {
            //Modify entity state + saveChanges
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
