﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartLakes.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult DisplayData()
        {
            return View("DataView");
        }
        
    }
}