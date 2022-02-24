using System;
using CalCalculator.BaseLib;
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
    public partial class AddWorkoutForm : Form, IAddWorkoutForm
    {
        public AddWorkoutForm()
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

        public string WorkoutName => textBoxName.Text;
        
        public double WorkoutEnergy
        {
            get
            {
                double returnValue = 0;

                if (Double.TryParse(textBoxEnergy.Text, out returnValue) == true)
                    return returnValue;

                throw new ArgumentException();
            }
        }
        
    }
}
