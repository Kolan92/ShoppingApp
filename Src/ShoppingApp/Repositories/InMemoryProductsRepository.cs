using System.Collections.Generic;
using System.Linq;
using ShoppingApp.Models;
using Optional;

namespace ShoppingApp.Repositories
{
    internal class InMemoryProductsRepository : IProductsRepository
    {
        private readonly List<Product> innerCollection = new List<Product>
        {
            //Beach category
            new Product(1, "Sunglasses"),
            new Product(2, "Flip Flops"),
            new Product(3, "Swim Shorts"),

            //Hiking category
            new Product(4, "Map"),
            new Product(5, "Compass"),
            new Product(6, "Head Lamp")
        };

        public IEnumerable<Product> GetAll() => innerCollection.AsReadOnly();

        public Option<Product> GetById(int id)
        {
            var foundProduct = innerCollection.FirstOrDefault(product => product.Id == id);
            return foundProduct.NoneWhen(product => product == null);
        }
    }
}