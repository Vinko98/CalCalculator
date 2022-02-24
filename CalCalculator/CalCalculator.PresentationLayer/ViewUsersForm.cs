using System;
using CalCalculator.BaseLib;
using System.Collections.Generic;
using System.ComponentModel;
using CalCalculator.Model;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class ViewUsersForm : Form, IViewUsersForm
    {
        private List<User> users = null;
        private IMainFormController mainFormController = null;
        public ViewUsersForm()
        {
            InitializeComponent();
        }
        public void ViewUsers(List<User> users, IMainFormController mainFormController)
        {
            this.mainFormController = mainFormController;
            this.users = users;
            DisplayUsers();
            this.Show();
        }
        private void DisplayUsers()
        {
            for (int i = 0; i < users.Count(); i++)
            {
                User user = users[i];

                string userName = user.Name;
                string userHeight = user.Height.ToString();
                string userWeight = user.Weight.ToString();
                string userGender = user.Gender.ToString();
                string userAge = user.Age.ToString();
                string userEnergyBalance = user.EnergyValue.ToString();


                ListViewItem userRow = new ListViewItem(userName);
                userRow.SubItems.Add(userHeight);
                userRow.SubItems.Add(userWeight);
                userRow.SubItems.Add(userGender);
                userRow.SubItems.Add(userAge);
                userRow.SubItems.Add(userEnergyBalance);

                listViewUsers.Items.Add(userRow);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainFormController.EditUser(listViewUsers);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainFormController.DeleteUser(listViewUsers);
        }
    }
}
