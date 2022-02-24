using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    class EnergyExchangeTypes
    {
		public enum EnergyExchangeTypesEnum : int
		{
			ENERGY_INTAKE = 1,
			ENERGY_CONSUMPTION = 2,

		};

		public static Dictionary<EnergyExchangeTypesEnum, string> EnergyExchangeTypeDict = new Dictionary<EnergyExchangeTypesEnum, string>
		{
			{ EnergyExchangeTypesEnum.ENERGY_INTAKE, "Energy_intake"},
			{ EnergyExchangeTypesEnum.ENERGY_CONSUMPTION, "Energy_consumption"},
		};

		public static Dictionary<EnergyExchangeTypesEnum, Type> EnergyExchangeMappingToTypesDict = new Dictionary<EnergyExchangeTypesEnum, Type>
		{
			{ EnergyExchangeTypesEnum.ENERGY_INTAKE, typeof(Food)},
			{ EnergyExchangeTypesEnum.ENERGY_CONSUMPTION, typeof(Beverage)},
		};

		public static EnergyExchangeTypesEnum getEnergyExchangeCode(string inEnergyExchangeTypeName)
		{
			foreach (var val in EnergyExchangeTypeDict)
				if (val.Value == inEnergyExchangeTypeName)
					return val.Key;

			throw new WrongEnergyExchangeTypeNameInString();
		}

		public static string getEnergyExchangeTypeName(EnergyExchange inEnergyExchange)
		{
			foreach (var val in EnergyExchangeMappingToTypesDict)
				if (val.Value == inEnergyExchange.GetType())
					return EnergyExchangeTypeDict[val.Key];

			throw new EnergyExchangeTypeNotInList();
		}

		public static List<string> getEnergyExchangeTypesList()
		{
			return EnergyExchangeTypeDict.Select(a => a.Value).ToList();
		}

		public static bool isEnergyExchangeOfType(EnergyExchange inEnergyExchange, EnergyExchangeTypesEnum inType)
		{
			if (inEnergyExchange.GetType() == EnergyExchangeMappingToTypesDict[inType])
				return true;

			return false;
		}
	}
}
