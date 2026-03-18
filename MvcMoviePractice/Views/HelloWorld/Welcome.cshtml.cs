using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MvcMoviePractice.Views.HelloWorld
{
    public class Welcome(ILogger<Welcome> logger) : PageModel
    {
        private readonly ILogger<Welcome> _logger = logger;

        public void OnGet() { }
    }
}
