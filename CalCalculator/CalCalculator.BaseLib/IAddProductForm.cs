using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IAddProductForm
    {
        bool ShowForm();

        string ProductName { get; }
        string ProductType { get; }
        double EnergyOn100 { get; }
       // double Amount { get; }
    }
}
