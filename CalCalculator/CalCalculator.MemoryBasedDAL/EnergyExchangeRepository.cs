using CalCalculator.Model;
using CalCalculator.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.MemoryBasedDAL
{
    public class EnergyExchangeRepository : IEnergyExchangeRepository
    {
        private static int id = 1;
        private readonly List<EnergyExchange> energyExchanges = new List<EnergyExchange>();

        public int GetNewEnergyExchangeId()
        {
            int nextId = id;
            id++;
            return nextId;
        }

        public EnergyExchange GetEnergyExchangeById(int energyExchangeId)
        {
            var energyExchange = (from l in energyExchanges where l.Id == energyExchangeId select l).First();
            return energyExchange;
        }

        public List<EnergyExchange> GetAllEnergyExchanges()
        {
            return energyExchanges;
        }

        public List<int> GetAllEnergyExchangesIds()
        {
            return energyExchanges.Select(energyExchange => energyExchange.Id).ToList();
        }

        public List<int> GetAllUsersIds()
        {
            return energyExchanges.Select(energyExchange => energyExchange.Id).ToList();
        }

        public void AddEnergyExchange(EnergyExchange newEnergyExchange)
        {
            if (energyExchanges.Any(energyExchange => energyExchange.Id == newEnergyExchange.Id))
            {
                throw new EnergyExchangeAlreadyExists();
            }
            else
            {
                energyExchanges.Add(newEnergyExchange);
            }
        }

        public void DeleteEnergyExchange(EnergyExchange energyExchange)
        {

        }

    }
}
