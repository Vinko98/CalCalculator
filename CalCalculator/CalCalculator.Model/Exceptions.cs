using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
   
    [Serializable]
    public class CalCalculatorException : Exception
    {
    }
    
    [Serializable]
    public class WrongProductTypeInString : CalCalculatorException
    {
    }
    
    [Serializable]
    public class ProductDoesntExist : CalCalculatorException
    {
    }

    [Serializable]
    public class AccountAlreadyExists : CalCalculatorException
    {
    }

    [Serializable]
    public class ProductAlreadyExists: CalCalculatorException
    {
    }

    [Serializable]
    public class MealDoesntExist : CalCalculatorException
    {
    }

    [Serializable]
    public class MealAlreadyExists : CalCalculatorException
    {
    }

    [Serializable]
    public class UserDoesntExist : CalCalculatorException
    {
    }

    [Serializable]
    public class UserAlreadyExists : CalCalculatorException
    {
    }

    [Serializable]
    public class EnergyExchangeAlreadyExists: CalCalculatorException
    {
    }

    [Serializable]
    public class WorkoutAlreadyExists : CalCalculatorException
    {
    }

    [Serializable]
    public class WrongProductTypeNameInString : CalCalculatorException
    {
    }

    [Serializable]
    public class ProductTypeNotInList : CalCalculatorException
    {
    }

    [Serializable]
    public class WorkoutDoesntExist : CalCalculatorException
    {
    }

    [Serializable]
    public class WrongEnergyExchangeTypeNameInString : CalCalculatorException
    {
    }

    [Serializable]
    public class EnergyExchangeTypeNotInList : CalCalculatorException
    {
    }



}
