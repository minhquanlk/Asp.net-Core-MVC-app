﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nazox.Tables
{
    public class TablesBasicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
