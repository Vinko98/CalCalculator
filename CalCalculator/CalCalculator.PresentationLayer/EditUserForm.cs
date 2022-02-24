using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CalCalculator.BaseLib;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class EditUserForm : Form, IEditUserForm
    {
        public EditUserForm()
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

        public string UserName => textBoxName.Text;
        public string UserGender => textBoxGender.Text;
        public double UserHeight
        {
            get
            {
                double returnValue = 0;

                if (Double.TryParse(textBoxHeight.Text, out returnValue) == true)
                    return returnValue;

                throw new ArgumentException();
            }
        }
        public double UserWeight
        {
            get
            {
                double returnValue = 0;

                if (Double.TryParse(textBoxWeight.Text, out returnValue) == true)
                    return returnValue;

                throw new ArgumentException();
            }
        }
        public int UserAge
        {
            get
            {
                return Int16.Parse(textBoxAge.Text);
            }
        }
    }
}
