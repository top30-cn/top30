using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Common.BaseClass
{
    public class BaseController : Controller
    {
        public static BLL.Menu menuBLL = new BLL.Menu();
        public static List<Model.MenuViewModel> menuData = menuBLL.GetMenuList();
        public BaseController()
        {
            ViewBag.MenuList = menuData;
        }   
    }
}
