using ShoesStore.DAL.EF;
using ShoesStore.DAL.Entities;
using ShoesStore.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace ShoesStore.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ApplicationContext Context { get; set; }

        public ProductRepository(ApplicationContext context)
        {
            Context = context;
        }

        public IEnumerable<Product> Products { get => Context.Products; }

        public void AddProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            Context.Products.Add(product);
            Context.SaveChanges();
        }

        public void RemoveProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            Context.Products.Remove(product);
            Context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            Context.Products.Update(product);
            Context.SaveChanges();
        }
    }
}
