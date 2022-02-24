using CalCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IViewProductsForm
    {
        void ViewProducts(List<Product> products, IMainFormController mainFormController);
    }
}
