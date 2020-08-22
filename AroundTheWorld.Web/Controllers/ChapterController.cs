using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AroundTheWorld.Web.Controllers
{
    public class ChapterController : Controller
    {
        public IActionResult EditChapter()
        {
            return View();
        }

        public IActionResult DeleteChapter()
        {
            return View();
        }
    }
}