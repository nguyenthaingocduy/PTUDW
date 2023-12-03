using MyClass.DAO;
using MyClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _63CNTT4N2.Controllers
{
    public class ModuleController : Controller
    {
        MenusDAO menusDAO = new MenusDAO();
        // GET: Module

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MainMenu()
        {
            List<Menus> list = menusDAO.getListByParentId(0,"MainMenu");
            return View(list);
        }
        public ActionResult Slider()
        {
            SlidersDAO slidersDAO = new SlidersDAO();
            List<Sliders> list = slidersDAO.getListByPosition("slider");//ten ham dat tuy y
            return View("Slider", list);
        }
        public ActionResult MenuFooter()
        {
            MenusDAO menusDAO = new MenusDAO();
            List<Menus> list = menusDAO.getListByParentId(0, "Footer");
            return View("MenuFooter", list);
        }
    }
}