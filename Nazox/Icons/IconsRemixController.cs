﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nazox.Icons
{
    public class IconsRemixController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
