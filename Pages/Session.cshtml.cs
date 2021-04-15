using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebFizzBuzz.Data;
using WebFizzBuzz.Form;

namespace WebFizzBuzz.Pages
{
    public class Index1Model : PageModel
    {
        private readonly ILogger<Index1Model> _logger;
        public Address Addr { get; set; }

        public IList<Address> Numbers { get; set; }
        public Index1Model(ILogger<Index1Model> logger)
        {
            _logger = logger;
        }
        public void OnGet() {
            var liczba = HttpContext.Session.GetString("Number");
            if (liczba != null) Addr = JsonConvert.DeserializeObject<Address>(liczba);
        }
    }
}
