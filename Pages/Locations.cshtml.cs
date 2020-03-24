using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jacobpugsley.Pages
{
    public class LocationsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your locations page.";
        }
    }
}