using ProductApp.Entities;
using System.Collections.Generic;

namespace ProductApp.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(int id);
    }
}
