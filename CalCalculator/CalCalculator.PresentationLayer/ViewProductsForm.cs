using CalCalculator.Model;
using CalCalculator.Model.Factories;
using CalCalculator.BaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class ViewProductsForm : Form, IViewProductsForm
    {
        private List<Product> productsForm = null;
        private IMainFormController mainFormController = null;
        public ViewProductsForm()
        {
            InitializeComponent();
        }

        public void ViewProducts(List<Product> products, IMainFormController mainFormController)
        {
            this.mainFormController = mainFormController;
            productsForm = products;
            DisplayProducts();
            this.Show();
        }

        private void DisplayProducts()
        {
            for (int i = 0; i < productsForm.Count(); i++)
            {
                Product product = productsForm[i];

                string productType = ProductTypes.getProductTypeName(product); ;
                string productName = product.Name;
                string productEnergyOn100 = product.EnergyOn100.ToString();
                string productAmount = product.Amount.ToString();


                ListViewItem productRow = new ListViewItem(productType);
                productRow.SubItems.Add(productName);
                productRow.SubItems.Add(productEnergyOn100);
                productRow.SubItems.Add(productAmount);

                listViewProducts.Items.Add(productRow);
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainFormController.EditProduct(listViewProducts);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            mainFormController.DeleteProduct(listViewProducts);
        }
    }
}
