using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IAddUserForm
    {
        bool ShowForm();
        string UserName { get; }
        double UserHeight { get; }
        double UserWeight { get; }
        string UserGender { get; }
        int UserAge { get; }
    }
}
