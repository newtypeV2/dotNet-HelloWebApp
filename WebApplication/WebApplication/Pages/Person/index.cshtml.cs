using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Website.Models;
using WebApplication.Website.Services;

namespace WebApplication.Website
{
    public class indexModel : PageModel
    {
        private readonly ILogger<indexModel> _logger;
        public JsonFilePersonService PersonService;
        public IEnumerable<Person> People { get; private set; }

        public indexModel(ILogger<indexModel> logger,
            JsonFilePersonService personService)
        {
            _logger = logger;
            PersonService = personService;
        }
        public void OnGet()
        {
           People = PersonService.GetPeople();
        }
    }
}