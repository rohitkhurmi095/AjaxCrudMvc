using ClothBazar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Business.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int Id);
        void Add(Product category);
        void Update(Product category);
        void Remove(int Id);
    }
}
