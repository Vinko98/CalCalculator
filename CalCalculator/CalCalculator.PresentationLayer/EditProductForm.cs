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
    public partial class EditProductForm : Form, IEditProductForm
    {
        public EditProductForm()
        {
            InitializeComponent();
        }

        public bool ShowForm()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string ProductName => textBoxName.Text;
        public double EnergyOn100
        {
            get
            {
                double returnValue = 0;

                if (Double.TryParse(textBoxEnergy.Text, out returnValue) == true)
                    return returnValue;

                throw new ArgumentException();
            }
        }
        //public double Amount
        //{
        //    get
        //    {
        //        double returnValue = 0;
        //
        //        if (Double.TryParse(textBoxAmount.Text, out returnValue) == true)
        //            return returnValue;
        //
        //        throw new ArgumentException();
        //    }
        //}
    }
}
