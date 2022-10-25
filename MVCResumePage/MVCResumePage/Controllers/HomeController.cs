using Microsoft.AspNetCore.Mvc;
using MVCResumePage.Models;
using System.Diagnostics;

namespace MVCResumePage.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Resume()
        {
            Biodata biodata = new Biodata();
            biodata.Name = "Herry Wijaya";
            biodata.Occupation = "C#/.NET Developer";
            biodata.Email = "herrywijaya065116076@unpak.ac.id";
            biodata.Links = new string[,] { {"http://zodiark619.pythonanywhere.com","fa-globe" },
                { "https://www.linkedin.com/in/herry-wijaya-78b7a5216/","fa-linkedin" },
                { "https://github.com/zodiark619","fa-github" },
                { "https://www.youtube.com/channel/UC06Fy-y5rnmMG3TKKycCR4g","fa-youtube" } };
            biodata.ProfilePicUrl = "foto.jpg";
            biodata.Description = new() { "\tMy name is Herry Wijaya. I graduated from Universitas Pakuan as Bachelor " +
                "Degree of Computer Science. My main programming language is C# and my main skill is developing " +
                "WebAPI service using repository pattern and clean architecture with .NET. I have 3 months work experience as frontend web developer. My achievements are having completed " +
                "numerous Udemy course regarding C# and .NET framework usages and have received MTA 98-381 certification. " ,


                    "I'm familiar with the following technologies: ",
"Frameworks= WebAPI, MVC, Blazor, WPF, Razor.",
                "Tools= Postman, Docker, MySQLServer, SeriLog."};


            biodata.PortofolioUrl = new string[,]
            {
                { "Portfolio1_MatchGame.jpg","Portfolio 1 MatchGame","WPF"},
                { "Portfolio1_StringChallenge1.jpg","String challenge","ConsoleApp"},
                { "Portfolio2_CalculatorPertamina.jpg","Portfolio 2 Pertamina Calculator","WPF"},
                { "Portfolio3_AzurLaneGachaSimulator.jpg","Portfolio 3 Azur Lane Gacha Simulator","WPF"},
                { "Portfolio4_AzurLaneGachaSimulator2.jpg","Portfolio 4 Azur Lane Gacha Simulator","Blazor"},

            };
          



            biodata.Work = new() {
                {new Work{WorkName="Frontend Web Developer",
                    Description="Information System for Warehouse Inventory Management is developed to make admin's responsibility on forwarding warehouse inventory's "+
"monthly report to finance's division more efficient by replacing handwritten manual input. Technology used is Python, Django, Bootstrap, and SQLite.", 


                    Location="DSP Styling",Duration=3,Url="https://drive.google.com/file/d/11U1Ilqm2k2E1m65y6iAyNHdOH0jmJBdL/view?usp=sharing" } },
            };
            biodata.Education = new()
            {
                {new Education{EducationName="Bachelor Degree of Computer Science",InstitutionName="Universitas Pakuan",StartYear=2016,EndYear=2021} }
            };

            biodata.Skill = new string[,]
            {
                {"C#","Fluent" ,},
                {".NET WebAPI","Moderate" },
                {".NET WPF","Beginner" },
                {".NET MVC","Beginner" },
                {".NET Blazor","Beginner" },

            };


            biodata.PortofolioPicUrl = new string[,] {
                { "pic_AddEmployee.JPG","AdventureWorks2019 WebAPI",".NET WebAPI"},
                
                { "pic_DepartmentCRUD.JPG","AdventureWorks2019 WebAPI",".NET WebAPI"},
                { "pic_EditEmployee.JPG","AdventureWorks2019 WebAPI",".NET WebAPI"},
                { "pic_EmployeeDashboard.JPG","AdventureWorks2019 WebAPI",".NET WebAPI"},

                { "pic_SearchEmployee.JPG","AdventureWorks2019 WebAPI",".NET WebAPI"},



             

            };
            
            return View("Resume",biodata);
        }

    }
}