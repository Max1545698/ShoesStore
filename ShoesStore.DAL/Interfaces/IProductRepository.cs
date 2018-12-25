using ShoesStore.DAL.Entities;
using System.Collections.Generic;

namespace ShoesStore.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void AddProduct(Product product);

        void RemoveProduct(Product product);

        void UpdateProduct(Product product);
    }
}
