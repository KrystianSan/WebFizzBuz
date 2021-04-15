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
using WebFizzBuzz.Data;
using WebFizzBuzz.Form;

namespace WebFizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Numbers _context; //readonly?
        [BindProperty]
        public Address Address { get; set; }

        [BindProperty(SupportsGet = true)]
        public String Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger, Numbers context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        { 
            if (string.IsNullOrWhiteSpace(Name))
                Name = "User";
        }

        //public IList<Address> Numbers { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Address.Date = DateTime.Now;
                DoResult();
                HttpContext.Session.SetString("Number", JsonConvert.SerializeObject(Address));

                _context.Address.Add(Address);
                _context.SaveChanges();

                Name = "User";
                return Page();
            }
            Name = "User";
            return Page();
        }

        public void DoResult()
        {
            Address.Result = "";
            if (Address.Number % 3 == 0)
            {
                Address.Result += "Fizz";
            }
            if (Address.Number % 5 == 0)
            {
                Address.Result += "Buzz";
            }
            else Address.Result = "Liczba " + Address.Number + " nie spełnia kryteriów Fizz/Buzz";
        }
    }
}
