using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcMoviePractice.Controllers.Views.HelloWorld
{
    public class Index(ILogger<Index> logger) : PageModel
    {
        private readonly ILogger<Index> _logger = logger;

        public void OnGet() { }
    }
}
