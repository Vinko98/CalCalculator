using System;
using CalCalculator.Controllers;
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
    public partial class MainForm : Form
    {
        private readonly MainFormController controller;
        public MainForm(MainFormController controller)
        {
            this.controller = controller;
            InitializeComponent();
            HideAllSubmenus();
        }

        private void HideAllSubmenus()
        {
            panelMealSubmenu.Visible = false;
            panelProductSubmenu.Visible = false;
            panelWorkoutSubmenu.Visible = false;
            panelUserSubmenu.Visible = false;
            panelEnergyExchangeSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideAllSubmenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelProductSubmenu);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            controller.AddProduct();
            HideAllSubmenus();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            controller.ViewProducts();
            HideAllSubmenus();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelMealSubmenu);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            controller.AddMeal();
            HideAllSubmenus();
        }

        private void btnViewMeals_Click(object sender, EventArgs e)
        {
            controller.ViewMeals();
            HideAllSubmenus();
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelWorkoutSubmenu);
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            controller.AddWorkout();
            HideAllSubmenus();
        }

        private void btnViewWorkouts_Click(object sender, EventArgs e)
        {
            controller.ViewWorkouts();
            HideAllSubmenus();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelUserSubmenu);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            controller.AddUser();
            HideAllSubmenus();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            controller.ViewUsers();
            HideAllSubmenus();
        }

        private void btnEnergyExchange_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelEnergyExchangeSubmenu);
        }

        private void btnViewEnergyExchange_Click(object sender, EventArgs e)
        {
            controller.ViewEnergyExchanges();
            HideAllSubmenus();
        }

        private void btnAddEnergyIntake_Click(object sender, EventArgs e)
        {
            controller.AddEnergyIntake();
            HideAllSubmenus();
        }

        private void btnAddEnergyConsumption_Click(object sender, EventArgs e)
        {
            controller.AddEnergyConsumption();
            HideAllSubmenus();
        }

        
    }
}
