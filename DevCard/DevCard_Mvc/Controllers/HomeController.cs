using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {


      
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult contact()
        {
            return View(new Contact());
        }
        [ValidateAntiForgeryToken]
        public IActionResult GetContact(Contact contact)
        {
            return Ok();
        }

        
        
    }
}
