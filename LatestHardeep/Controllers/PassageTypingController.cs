﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LatestHardeep.Controllers
{
    public class PassageTypingController : Controller
    {
        // GET: PassageTyping
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Passage(string id)
        {
            switch (id)
            {
                case "1":
                    return View("Page1");
                case "2":
                    return View("Page2");
                case "3":
                    return View("Page3");
                case "4":
                    return View("Page4");
                case "5":
                    return View("Page5");
                case "6":
                    return View("Page6");
                case "7":
                    return View("Page7");
                case "8":
                    return View("Page8");
                case "9":
                    return View("Page9");
                case "10":
                    return View("Page10");
                case "11":
                    return View("Page11");
                case "12":
                    return View("Page12");
                case "13":
                    return View("Page13");
                case "14":
                    return View("Page14");
                case "15":
                    return View("Page15");
                case "16":
                    return View("Page16");
                case "17":
                    return View("Page17");
                case "18":
                    return View("Page18");
                case "19":
                    return View("Page19");
                case "20":
                    return View("Page20");
                case "21":
                    return View("Page21");
                case "22":
                    return View("Page22");
                case "23":
                    return View("Page23");
                case "24":
                    return View("Page24");
                case "25":
                    return View("Page25");
                case "26":
                    return View("Page26");
                case "27":
                    return View("Page27");
                case "28":
                    return View("Page28");
                default:
                    return View("Index");
            }
        }

    }
}