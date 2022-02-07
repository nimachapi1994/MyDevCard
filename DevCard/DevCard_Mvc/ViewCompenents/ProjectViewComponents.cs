
using System;
using Microsoft.AspNetCore.Mvc;
using DevCard_Mvc.Models;
using System.Collections.Generic;

namespace DevCard_Mvc.ViewCompenents
{
    [ViewComponent(Name = "Project")]
    public class ProjectViewComponents:ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {

            List<Project> projects = new List<Project>()
            {
                new Project
                {
                    Id=1,
                    Client="google.com",
                    Description="سلام خدمت شما دوستان گرامی",
                    Name="salam man nima hastam",
                    Image="project-2.jpg"
                },
                new Project
                {
                    Id=1,
                    Client="google.com",
                    Description="سلام خدمت شما دوستان گرامی",
                    Name="salam man nima hastam",
                    Image="project-1.jpg"
                },
                new Project
                {
                    Id=1,
                    Client="google.com",
                    Description="سلام خدمت شما دوستان گرامی",
                    Name="salam man nima hastam",
                    Image="project-3.jpg"
                }
            };


            return View("Project",projects);
        }
    }
}
