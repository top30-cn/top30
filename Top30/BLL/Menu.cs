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
            List<T_Menu> modelList = DBBase.SingDBContext.T_Menu.Where(m => m.IsEnabled == Common.IsEnabled.Y).ToList();
            List<MenuViewModel> menuViewList = new List<MenuViewModel>();
            foreach (var m in modelList)
            {
                menuViewList.Add(new MenuViewModel(m));
            }
            return menuViewList;
        }
    }
}
