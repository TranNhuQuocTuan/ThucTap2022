using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ThucTap2022.Controllers
{
    public class ThucTap2022Controller1 : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
