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
    }
}
