using CalCalculator.BaseLib;
using CalCalculator.Model;
using System;
using System.Collections.Generic;
using CalCalculator.Model.Repositories;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class AddMealForm : Form, IAddMealForm
    {
        private readonly List<string> mealProductsNames = null;
        private IProductRepository productRepository = null;
        private List<Product> mealProducts = null;
        private double TotalEnergy = 0;
        public AddMealForm(IProductRepository productRepository)
        {
            InitializeComponent();
            this.productRepository = productRepository;
            mealProductsNames = productRepository.GetAllProductNames();
            mealProducts = new List<Product>();
        }

        public bool ShowForm()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string MealName => textBoxMealName.Text;
        

        public List<Product> GetMealProducts()
        {
            return mealProducts;
        }

        //public double MealAmount
        //{
        //    get
        //    {
        //        double returnValue = 0;
        //
        //        if (Double.TryParse(textBoxMealAmount.Text, out returnValue) == true)
        //            return returnValue;
        //
        //        throw new ArgumentException();
        //    }
        //}

        private void AddMealForm_Load(object sender, EventArgs e)
        {
            foreach (string s in mealProductsNames)
                comboBoxMealProduct.Items.Add(s);
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
    }
}
