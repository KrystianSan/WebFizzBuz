using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebFizzBuzz.Form;

namespace WebFizzBuzz.Pages
{
    public class Index1Model : PageModel
    {
        public Address Addr { get; set; }
        public string Result = "";
        public void OnGet()
        {
            var liczba = HttpContext.Session.GetString("Number");
            if (liczba != null) Addr = JsonConvert.DeserializeObject<Address>(liczba);

            if (Addr.Number % 3 == 0)
            {
                this.Result += "Fizz";
            }
            if (Addr.Number % 5 == 0)
            {
                this.Result += "Buzz";
            }
            else Result = "Liczba " + Addr.Number + "nie spe³nia kryteriów Fizz/Buzz";
        }
    }
}
