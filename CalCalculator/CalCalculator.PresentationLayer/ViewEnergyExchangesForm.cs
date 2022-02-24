using System;
using System.Collections.Generic;
using CalCalculator.Model;
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
    public partial class ViewEnergyExchangesForm : Form, IViewEnergyExchangesForm
    {
        private List<EnergyExchange> energyExchanges = null;
        public ViewEnergyExchangesForm()
        {
            InitializeComponent();
        }

        public void ViewEnergyExchanges(List<EnergyExchange> energyExchanges)
        {
            this.energyExchanges = energyExchanges;
            DisplayEnergyExchanges();
            this.Show();
        }

        private void DisplayEnergyExchanges()
        {
            for (int i = 0; i < energyExchanges.Count(); i++)
            {
                EnergyExchange energyExchange = energyExchanges[i];

                string date = energyExchange.Time.ToString();
                string energyFrom = energyExchange.EnergyFrom.Name.ToString();
                string energyTo = energyExchange.EnergyTo.Name.ToString();
                string energy;
                if (energyFrom.GetType().Equals(typeof(User)))
                    energy = energyExchange.EnergyTo.EnergyValue.ToString();
                else
                    energy = energyExchange.EnergyFrom.EnergyValue.ToString();
                //List<string> productNames = mealRepository.GetAllProductNamesByMealName(mealName);

                ListViewItem energyExchangeRow = new ListViewItem(date);
                energyExchangeRow.SubItems.Add(energyFrom);
                energyExchangeRow.SubItems.Add(energyTo);
                energyExchangeRow.SubItems.Add(energy);

                listViewEnergyExchange.Items.Add(energyExchangeRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
