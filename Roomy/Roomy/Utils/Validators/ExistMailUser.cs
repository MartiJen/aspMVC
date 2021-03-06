﻿using Roomy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    public class ExistMailUser : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            using (RoomyDbContext db = new RoomyDbContext())
            {
                return !db.Users.Any(x => x.Mail == value.ToString());
            }
        }


    }
}