using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalCalculator.Model;
using CalCalculator.Model.Factories;
using CalCalculator.Model.Repositories;
using CalCalculator.BaseLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Controllers
{
    class UserController
    {
		public void AddUser(IAddUserForm form, IUserRepository userRepository)
		{
			if (form.ShowForm() == true)
			{
				try
				{
					string name = form.UserName;
					double height = form.UserHeight;
					double weight = form.UserWeight;
					int age = form.UserAge;
					string gender = form.UserGender;

					int id = userRepository.GetNewUserId();

					User user = UserFactory.CreateUser(name, height, weight, gender, age, id);
					userRepository.AddUser(user);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewUsers(IViewUsersForm viewUsersForm, IUserRepository userRepository, IMainFormController mainFormController)
		{
			List<User> users = userRepository.GetAllUsers();
			viewUsersForm.ViewUsers(users, mainFormController);
		}

		public void EditUser(IEditUserForm form, IUserRepository userRepository, ListView listView, int index)
		{
			if (form.ShowForm() == true)
			{
				try
				{

					string name = form.UserName;
					double height = form.UserHeight;
					double weight = form.UserWeight;
					int age = form.UserAge;
					string gender = form.UserGender;
					//double pAmount = form.Amount;
					listView.SelectedItems[0].Text = form.UserName;
					listView.SelectedItems[0].SubItems[1].Text = form.UserHeight.ToString();
					listView.SelectedItems[0].SubItems[2].Text = form.UserWeight.ToString();
					listView.SelectedItems[0].SubItems[3].Text = form.UserGender.ToString();
					listView.SelectedItems[0].SubItems[4].Text = form.UserAge.ToString();
					//listView.SelectedItems[0].SubItems[3].Text = form.Amount.ToString();

					userRepository.EditUser(name, height, weight, gender, age, index);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}
		
		public void DeleteUser(IUserRepository userRepository, ListView listView, int index)
		{
			foreach (ListViewItem item in listView.SelectedItems)
			{
				listView.Items.Remove(item);
			}

			userRepository.DeleteUser(index);
		}
	}
}

