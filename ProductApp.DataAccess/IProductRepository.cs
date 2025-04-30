using ProductApp.Entities;
using System.Collections.Generic;

namespace ProductApp.DataAccess
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(int id);
    }
}
