using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SzerveroldaliBeadando.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Ez az index oldal.";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Szia {name}, ID: {ID}");
        }
    }
}
