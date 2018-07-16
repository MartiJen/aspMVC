using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class User
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Mail { get; set; }

        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

        public string ConfirmePassword { get; set; }
    }
}