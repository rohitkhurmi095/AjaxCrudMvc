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
    public class CategoryService : ICategoryService
    {
        //DbContext instance
        //-------------------
        private CBDbContext db = new CBDbContext();


        //Add new Category
        //================
        public void Add(Category category)
        {
            //Add Category to db + saveChanges()
            db.Categories.Add(category);
            db.SaveChanges();

        }

        //Get All Categories
        //====================
        public List<Category> GetAll()
        {
            //Categories list
            return db.Categories.ToList();
        }

        //Get Category by Id
        //===================
        public Category GetById(int Id)
        {
            //Find Category by Id
            return db.Categories.Find(Id);
        }

        //Remove Category
        //================
        public void Remove(int Id)
        {
            //Find Category by Id
            var category = GetById(Id);

            //Remove category + saveChanges()
            db.Categories.Remove(category);
            db.SaveChanges();
                
        }

        //Update Category
        //================
        public void Update(Category category)
        {
            //Modify entity state + saveChanges
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
