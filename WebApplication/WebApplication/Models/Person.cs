using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication.Website.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Person>(this);
    }

}
