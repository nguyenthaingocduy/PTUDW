﻿using MyClass.DAO;
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
            List<Menus> list = menusDAO.getListByParentId(0);
            return View(list);
        }
    }
}