using System.Collections.Generic;
using ShoppingApp.Models;
using Optional;

namespace ShoppingApp.Repositories
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetAll();
        Option<Product> GetById(int id);
    }
}