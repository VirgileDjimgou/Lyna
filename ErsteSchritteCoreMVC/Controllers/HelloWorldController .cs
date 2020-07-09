using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ErsteSchritteCoreMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        // 
        // GET: /HelloWorld/

        public IActionResult Index()
            {
                return View();
            }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }


    }
}
