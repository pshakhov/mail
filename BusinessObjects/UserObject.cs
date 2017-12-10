//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MailTest.BusinessObject
{
    class UserObject
    {
        private string Ident { get; set; }
        private string Password { get; set; }
        public UserObject(string ident, string pass)
        {
            Ident = ident;
            Password = pass;
        }

        public string SetIdent()
        {
            return Ident;
        }

        public string SetPass()
        {
            return Password;
        }
    }
}
