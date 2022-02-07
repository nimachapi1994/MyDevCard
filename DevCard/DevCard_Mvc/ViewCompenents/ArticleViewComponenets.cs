using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.ViewCompenents
{
    [ViewComponent(Name = "Article")]
    public class ArticleViewComponenets : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Articel>()
            {
                new Articel(1,"ok","hi"),
                new Articel(1,"ok","hi"),
                new Articel(1,"ok","hi"),
                new Articel(1,"ok","hi")
            };

            return View("Article",article);
        }
    }
}
