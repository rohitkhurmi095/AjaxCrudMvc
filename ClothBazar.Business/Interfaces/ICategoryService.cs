using ClothBazar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Business.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int Id);
        void Add(Category category);
        void Update(Category category);
        void Remove(int Id);
    }
}
