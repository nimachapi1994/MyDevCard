using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace DevCard_Mvc.Controllers
{
    public class Test : Controller
    {
        public IActionResult nima()
        {

            // can return partial view
            return View("Footer");
        }
        // باید به این اکشن اشاره شود حتما
        public ContentResult contact()
        {
            //return Content("<h1 style='color:blue'> hello asp.net core mvc </h1>", "text/html");

            return Content(" <script>alert('hi welcome to my website')</script> </br> <h1>Hi Welcome To My Website</h1>", "text/html");
        }
        public IActionResult About()
        {
            //return Content("<h1 style='color:blue'> hello asp.net core mvc </h1>", "text/html");


            return Content(" <script>alert('hi welcome to my website')</script> </br> <h1>Hi Welcome To My Website</h1>", MediaTypeNames.Text.Html);
        }
        //public EmptyResult shop() // void
        //{
        //    return new EmptyResult();
        //}

        public IActionResult ok()
        {
            return new EmptyResult();
        }

        public FileResult myFileDl()
        {
            //read by browser
            //  return File("~/file.txt", "text/html");

            byte[] myFile = System.IO.File.ReadAllBytes("wwwroot/file.txt");
            const string name = "text.txt";

            //   System.IO.FileStream fileStream = new FileStream("wwwroot/file.txt", FileMode.Open);

            return File(myFile, contentType: MediaTypeNames.Text.Plain, name);

        }
        public IActionResult File2()
        {
            return File(System.IO.File.ReadAllBytes("wwwroot/file.txt"),
                  MediaTypeNames.Text.Plain, new String("nimachapi.txt") /*use name for this file to dl*/);
        }


        public JsonResult JsonResult()
        {
            object json = new { name = "nima", fname = "chapi", age = "27" };
            return Json(json);
        }

        public ContentResult trythis()
        {
            return new myJs("alert('hiiiiiiiiiiiiiiiiiiiiiiiiiii')");
        }

        public IActionResult statuscodes()
        {
            return new BadRequestResult();
            
        }


    }
        //نیاز نیست به این اکشن و کلاس اشاره شود و این بصورت خودکار از سمت سرور فراحوانی میشود

        public class myJs : ContentResult
        {
            public myJs(string data)
            {
                Content = data;
                ContentType = "application/javascript";
            }
        }


    
}
