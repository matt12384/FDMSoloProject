using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    public class ProductRepository : IProductRepository
    {
        SoloProjectEntities context;

        public ProductRepository()
        {
            context = new SoloProjectEntities();
        }

        public ProductRepository(SoloProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> productsFromDatabase = new List<Product>();

            if (context.Products != null)
            {
                foreach (Product product in context.Products)
                {
                    productsFromDatabase.Add(product);
                }
            }
            return productsFromDatabase;
        }

        public Product GetProductById(int productId)
        {
            Product product = null;

            product = context.Products.Find(productId);

            return product;
        }

        public List<Product> GetProductByString(string searchTerm)
        {
            IQueryable<Product> product = null;

                product = (context.Products.Where(s => s.SearchTerms.Contains(searchTerm)));
                return product.ToList();
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);

            context.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            Product productToUpdate = context.Products.Find(product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.Category = product.Category;
                productToUpdate.ImageLink = product.ImageLink;
                productToUpdate.NumberInStock = product.NumberInStock;
                productToUpdate.SearchTerms = product.SearchTerms;
            }

            context.SaveChanges();
        }

        public void RemoveProduct(int productId)
        {
            Product product = context.Products.Find(productId);

            context.Products.Remove(product);

            context.SaveChanges();
        }
    }
}
