//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using MailTest.BusinessObject;

namespace MailTest.TestData
{
    class UserDataGenerator
    {
        public static UserObject GenerateUser()
        {
            return new UserObject("pavel.shakhov.92@gmail.com", "f!$H3Y3$");
        }

        //public static UserObject GenerateUserPass()
        //{
        //    return new UserObject("f!$H3Y3$");
        //}
    }
}
