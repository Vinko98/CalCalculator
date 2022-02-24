using CalCalculator.BaseLib;
using CalCalculator.Model.Repositories;
using CalCalculator.Model.Factories;
using CalCalculator.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Controllers
{
	public class ProductController
	{
		public void AddProduct(IAddProductForm form, IProductRepository productRepository)
		{
			if (form.ShowForm() == true)
			{
				try
				{
					string name = form.ProductName;
					string productType = form.ProductType;
					double energyOn100 = form.EnergyOn100;
					//double amount = form.Amount;

					//int id = productRepository.GetNewProductId();

					Product product = ProductFactory.CreateProduct(name, productType, energyOn100);
					productRepository.AddProduct(product);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewProducts(IViewProductsForm viewProductsForm, IProductRepository productRepository, IMainFormController mainFormController)
		{
			List<Product> products = productRepository.GetAllProducts();
			viewProductsForm.ViewProducts(products, mainFormController);
		}

		public void EditProduct(IEditProductForm form, IProductRepository productRepository, ListView listView, int index)
        {
			if (form.ShowForm() == true)
			{
				try
				{

					string pName = form.ProductName;
					double pEnergyOn100 = form.EnergyOn100;
					//double pAmount = form.Amount;

					listView.SelectedItems[0].SubItems[1].Text = form.ProductName;
					listView.SelectedItems[0].SubItems[2].Text = form.EnergyOn100.ToString();
					//listView.SelectedItems[0].SubItems[3].Text = form.Amount.ToString();

					productRepository.EditProduct(pName, pEnergyOn100, index);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void DeleteProduct(IProductRepository productRepository, ListView listView, int index)
        {
			foreach(ListViewItem item in listView.SelectedItems)
            {
				listView.Items.Remove(item);
            }

			productRepository.DeleteProduct(index);
        }
    }
}
