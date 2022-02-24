using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class ProductTypes
    {
		public enum ProductTypesEnum : int
		{
			FOOD = 1,
			BEVERAGE = 2,
			
		};

		public static Dictionary<ProductTypesEnum, string> ProductTypeDict = new Dictionary<ProductTypesEnum, string>
		{
			{ ProductTypesEnum.FOOD, "Food"},
			{ ProductTypesEnum.BEVERAGE, "Beverage"},
		};

		public static Dictionary<ProductTypesEnum, Type> ProductMappingToTypesDict = new Dictionary<ProductTypesEnum, Type>
		{
			{ ProductTypesEnum.FOOD, typeof(Food)},
			{ ProductTypesEnum.BEVERAGE, typeof(Beverage)},
		};

		public static ProductTypesEnum getProductCode(string inProductTypeName)
		{
			foreach (var val in ProductTypeDict)
				if (val.Value == inProductTypeName)
					return val.Key;

			throw new WrongProductTypeNameInString();
		}

		public static string getProductTypeName(Product inProduct)
		{
			foreach (var val in ProductMappingToTypesDict)
				if (val.Value == inProduct.GetType())
					return ProductTypeDict[val.Key];

			throw new ProductTypeNotInList();
		}

		public static List<string> getProductTypesList()
		{
			return ProductTypeDict.Select(a => a.Value).ToList();
		}

		public static bool isProductOfType(Product inProduct, ProductTypesEnum inType)
		{
			if (inProduct.GetType() == ProductMappingToTypesDict[inType])
				return true;

			return false;
		}

	}
}
