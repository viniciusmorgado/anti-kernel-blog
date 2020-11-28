using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntiKernelBlog.Controllers
{
    public class PrivacyController : Controller
    {
        [Route("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
