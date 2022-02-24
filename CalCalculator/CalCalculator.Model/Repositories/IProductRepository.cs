using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Repositories
{
    public interface IProductRepository
    {
        //  int GetNewProductId();
        // Product GetProductById(int productId);
        int GetProductIndexByName(string productName);
        Product GetProductByName(string productName);
        List<Product> GetAllProducts();
        // List<int> GetAllProductsIds();
        void AddProduct(Product newProduct);
        void EditProduct(string productName, double productEnergyOn100, int index);
        void DeleteProduct(int index);
        List<string> GetAllProductNames();
        double GetProductEnergyByName(string productName);
        double GetProductAmountByName(string productName);
    }
}
