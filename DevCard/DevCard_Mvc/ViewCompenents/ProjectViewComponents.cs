
using System;
using Microsoft.AspNetCore.Mvc;


namespace DevCard_Mvc.ViewCompenents
{
    [ViewComponent(Name = "Project")]
    public class ProjectViewComponents:ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View("Project");
        }
    }
}
