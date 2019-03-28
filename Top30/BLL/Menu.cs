using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Menu
    {
        public Menu()
        {

        }
        public List<MenuViewModel> GetMenuList()
        {
            return DBBase.SingDBContext.T_Menu.Where(m => m.IsEnabled == Common.IsEnabled.Y)
                .Select(m => new MenuViewModel(m)).ToList();
        }
    }
}
