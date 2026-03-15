using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMoviePractice.Controllers
{
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        [Route("Welcome")]
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
