using CalCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IAddMealForm
    {
        bool ShowForm();

        string MealName { get; }
        List<Product> GetMealProducts();
        //double MealAmount { get; }
    }
}
