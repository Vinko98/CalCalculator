using System;
using System.Collections.Generic;
using CalCalculator.Model;
using CalCalculator.Model.Repositories;
using CalCalculator.BaseLib;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class EditMealForm : Form, IEditMealForm
    {
        private List<Product> mealProducts = null;
        private ListView listView = null;
        IMealRepository mealRepository = null;
        private IProductRepository productRepository = null;
        private readonly List<string> mealProductsNames = null;
        private double TotalEnergy = 0;
        public EditMealForm()
        {
            InitializeComponent();
        }
        public EditMealForm(ListView listView, IMealRepository mealRepository, IProductRepository productRepository)
        {
            InitializeComponent();
            this.mealRepository = mealRepository;
            this.listView = listView;
            this.productRepository = productRepository;
            mealProductsNames = productRepository.GetAllProductNames();
            try { 
                TotalEnergy = mealRepository.GetTotalMealEnergyByMealName(listView.SelectedItems[0].Text);
                mealProducts = mealRepository.GetAllProductsByMealName(listView.SelectedItems[0].Text);
            }
            catch(Exception e)
            {
                MessageBox.Show("First select something from table");
            }
            
        }
        public bool ShowForm()
        {
            DisplayMealProducts();
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }
        private void DisplayMealProducts()
        {
            for (int i = 0; i < mealProducts.Count(); i++)
            {
                Product product = mealProducts[i];

                string productName = product.Name;
                string productEnergy = product.CalculateTotalEnergy().ToString();
                string productAmount = product.Amount.ToString();
                //List<string> productNames = mealRepository.GetAllProductNamesByMealName(mealName);

                ListViewItem productRow = new ListViewItem(productName);
                productRow.SubItems.Add(productEnergy);
                productRow.SubItems.Add(productAmount);

                listViewProducts.Items.Add(productRow);
            }
        }
        public string MealName => textBoxMealName.Text;

        public List<Product> GetMealProducts()
        {
            return mealProducts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = comboBoxMealProduct.SelectedItem.ToString();
            Product addProduct = productRepository.GetProductByName(productName);
            double amount = 0;
            Double.TryParse(textBoxproductAmount.Text, out amount);
            addProduct.Amount = amount;
            double productEnergyd = productRepository.GetProductEnergyByName(productName);
            string productEnergy = productEnergyd.ToString();
            string productAmount = productRepository.GetProductAmountByName(productName).ToString();
            string[] row = { productName, productEnergy, productAmount };
            ListViewItem productRow = new ListViewItem(row);
            listViewProducts.Items.Add(productRow);

            mealProducts.Add(addProduct);

            TotalEnergy += productEnergyd;
            labelTotalEnergy.Text = TotalEnergy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = productRepository.GetProductIndexByName(listViewProducts.SelectedItems[0].Text);
            foreach (ListViewItem item in listViewProducts.SelectedItems)
            {
                listViewProducts.Items.Remove(item);
            }
            mealProducts.RemoveAt(index);
        }

        private void EditMealForm_Load(object sender, EventArgs e)
        {
            foreach (string s in mealProductsNames)
                comboBoxMealProduct.Items.Add(s);

            labelTotalEnergy.Text = TotalEnergy.ToString();
        }
    }
}
