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

<<<<<<< HEAD

=======
>>>>>>> c98aa6dd44887bf079f5f960b5971ac811557215
      
        public IActionResult Index()
        {
           
            return View();
        }
<<<<<<< HEAD
        public IActionResult contact()
=======
        public IActionResult Contact()
>>>>>>> c98aa6dd44887bf079f5f960b5971ac811557215
        {
            return View(new Contact());
        }
<<<<<<< HEAD
        [ValidateAntiForgeryToken]
        public IActionResult GetContact(Contact contact)
        {
            return Ok();
        }
=======
>>>>>>> c98aa6dd44887bf079f5f960b5971ac811557215

        
        
    }
}
