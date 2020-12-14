using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my defoult action...";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {ID}");
        }
    }
}
