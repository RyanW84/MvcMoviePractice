using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcMoviePractice.Views.HelloWorld
{
    public class Welcome(ILogger<Welcome> logger) : PageModel
    {
        private readonly ILogger<Welcome> _logger = logger;

        public void OnGet() { }
    }
}
