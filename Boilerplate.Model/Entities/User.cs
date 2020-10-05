using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Boilerplate.Model.Entities
{
    public class User : AEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
