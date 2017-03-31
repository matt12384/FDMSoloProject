using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    interface IProductRepository
    {
        List<Product> GetAllProducts();

        Product GetProductById(int productId);

        List<Product> GetProductByString(string searchTerm);

        void AddProduct(Product user);

        void EditProduct(Product user);

        void RemoveProduct(int productId);
    }
}
