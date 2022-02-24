using System;
using CalCalculator.Model;
using System.Collections.Generic;
using CalCalculator.Model.Factories;
using CalCalculator.Model.Repositories;
using CalCalculator.BaseLib;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Controllers
{
    class EnergyExchangeController
    {
		public void AddEnergyIntake(IAddEnergyIntakeForm form, IEnergyExchangeRepository energyExchangeRepository, IUserRepository userRepository)
		{
			if (form.ShowForm() == true)
			{
				try
				{

					DateTime energyTime = form.EnergyTime;
					Meal energyFrom = form.EnergyFrom;
					User energyTo = form.EnergyTo;
					int id = energyExchangeRepository.GetNewEnergyExchangeId();	

					EnergyExchange energyExchange = EnergyExchangeFactory.CreateEnergyExchange(energyTime, energyFrom, energyTo, id);
					energyExchangeRepository.AddEnergyExchange(energyExchange);
					userRepository.UpdateUserByName(energyTo.Name, energyFrom.EnergyValue, energyExchange);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}
		public void AddEnergyConsumption(IAddEnergyConsumptionForm form, IEnergyExchangeRepository energyExchangeRepository, IUserRepository userRepository)
		{
			if (form.ShowForm() == true)
			{
				try
				{

					DateTime energyTime = form.EnergyTime;
					User energyFrom = form.EnergyFrom;
					Workout energyTo = form.EnergyTo;
					int id = energyExchangeRepository.GetNewEnergyExchangeId();

					EnergyExchange energyExchange = EnergyExchangeFactory.CreateEnergyExchange(energyTime, energyFrom, energyTo, id);
					energyExchangeRepository.AddEnergyExchange(energyExchange);
					userRepository.UpdateUserByName(energyFrom.Name, -energyTo.EnergyValue, energyExchange);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewEnergyExchanges(IViewEnergyExchangesForm viewMealsForm, IEnergyExchangeRepository energyExchangeRepository)
		{
			List<EnergyExchange> energyExchanges = energyExchangeRepository.GetAllEnergyExchanges();
			viewMealsForm.ViewEnergyExchanges(energyExchanges);
		}
	}
}
