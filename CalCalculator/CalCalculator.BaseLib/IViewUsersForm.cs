using System;
using System.Collections.Generic;
using CalCalculator.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IViewUsersForm
    {
        void ViewUsers(List<User> users, IMainFormController mainFormController);
    }
}
