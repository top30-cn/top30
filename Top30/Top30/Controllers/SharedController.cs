using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace Top30.Controllers
{
    public class SharedController : Controller
    {
        Menu menuBLL = new Menu();
        // GET: Shared
        public ActionResult Index()
        {
            var menuList = menuBLL.GetMenuList();
            return View(menuList);
        }
    }
}