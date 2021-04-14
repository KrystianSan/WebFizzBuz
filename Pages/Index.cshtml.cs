using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebFizzBuzz.Form;

namespace WebFizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Address Address { get; set; }

        [BindProperty(SupportsGet = true)]
        public String Name { get; set; }
        public string Result;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        { 
            if (string.IsNullOrWhiteSpace(Name))
                Name = "User";
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Address.Date = DateTime.Now;
                HttpContext.Session.SetString("Number", JsonConvert.SerializeObject(Address));

                var liczba = HttpContext.Session.GetString("Number");
                if (liczba != null) Address = JsonConvert.DeserializeObject<Address>(liczba);
                Address.DoResult();

                return RedirectToPage("./History");
            }
            return Page();
        }
    }
}
