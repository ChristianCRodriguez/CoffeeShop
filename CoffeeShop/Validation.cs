using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CoffeeShop
{
    public class Validation
    {
        public bool PasswordMatch(string password, string verifyPassword)
        {
            return password == verifyPassword ? true : false;
        }

    }
}
