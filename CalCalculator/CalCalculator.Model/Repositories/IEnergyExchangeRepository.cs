using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Repositories
{
    public interface IEnergyExchangeRepository
    {
        int GetNewEnergyExchangeId();
        EnergyExchange GetEnergyExchangeById(int energyExchangeId);
       // EnergyExchange GetEnergyExchangeByName(string energyExchangeName);
        List<EnergyExchange> GetAllEnergyExchanges();
        List<int> GetAllEnergyExchangesIds();
        void AddEnergyExchange(EnergyExchange energyExchange);
        void DeleteEnergyExchange(EnergyExchange energyExchange);
    }
}
