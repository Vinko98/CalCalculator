using CalCalculator.Model.Repositories;
using CalCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.MemoryBasedDAL
{
    public class ProductRepository : IProductRepository
    {
        private static int id = 1;
        private readonly List<Product> products = new List<Product>();

        public int GetNewProductId()
        {
            int nextId = id;
            id++;
            return nextId;
        }

        //Product GetProductById(int productId)
        //{
        //    var acc = (from l in products where l.Id == productId select l).First();
        //    return acc;
        //}

        public int GetProductIndexByName(string productName)
        {
            var product = (from l in products where l.Name == productName select l).First();
            if (product != null)
            {
                return products.IndexOf(product);
            }
            throw new ProductDoesntExist();
        }

        public Product GetProductByName(string productName)
        {
            var product = (from l in products where l.Name == productName select l).First();

            if (product != null)
                return product;

            throw new ProductDoesntExist();
        }

        public List<string> GetAllProductNames()
        {
            return products.Select(a => a.Name).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        //List<int> GetAllProductsIds()
        //{
        //    return products.Select(product => product.Id).ToList();
        //}

        public void AddProduct(Product newProduct)
        {
            if (products.Any(product => product.Name == newProduct.Name))
            {
                throw new ProductAlreadyExists();
            }
            else 
            {
                products.Add(newProduct);
            }
        }
        public void EditProduct(string productName, double productEnergyOn100, int index)
        {
            products[index].Name = productName;
            products[index].EnergyOn100 = productEnergyOn100;
         
        }

        public void DeleteProduct(int index)
        {
            products.RemoveAt(index);
        }

        public double GetProductEnergyByName(string productName)
        {
            var product = (from l in products where l.Name == productName select l).First();
            return product.CalculateTotalEnergy();
        }

        public double GetProductAmountByName(string productName)
        {
            var product = (from l in products where l.Name == productName select l).First();
            return product.Amount;
        }

    }
}
