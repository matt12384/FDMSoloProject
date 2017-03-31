using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    [ServiceContract]
    interface IProductService
    {
        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        Product GetProductById(int productId);

        [OperationContract]
        List<Product> GetProductByString(string searchTerm);

        [OperationContract]
        void AddProduct(Product product);

        [OperationContract]
        void EditProduct(Product product);

        [OperationContract]
        void RemoveProduct(int productId);
    }
}
