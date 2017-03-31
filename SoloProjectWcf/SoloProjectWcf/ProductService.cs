using ModelPoco;
using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    public class ProductService : IProductService
    {
        ProductRepository repository;

        public ProductService()
        {
            repository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return repository.GetProductById(productId);
        }

        public List<Product> GetProductByString(string searchTerm)
        {
            return repository.GetProductByString(searchTerm);
        }

        public void AddProduct(Product product)
        {
            repository.AddProduct(product);
        }

        public void EditProduct(Product product)
        {
            repository.EditProduct(product);
        }

        public void RemoveProduct(int productId)
        {
            repository.RemoveProduct(productId);
        }
    }
}
