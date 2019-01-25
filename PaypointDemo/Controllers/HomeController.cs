//***************************************************************************************
//                          Written By Mike Valchera
//***************************************************************************************

using PaypointDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaypointDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new IndexModel());
        }

        public ActionResult SortString(IndexModel model)
        {
            model.SortedValues = Interfaces.NumberSorter.SortHighToLow(model.InputValues);
            return View("Index", model);
        }
    }
}