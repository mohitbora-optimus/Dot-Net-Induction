using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_15
{
    public class UserNameNotEnteredException : Exception
    {
        public UserNameNotEnteredException()
            : base("Error : enter user name ")
        { }
    }

    public class PasswordNotEnteredException : Exception
    {
        public PasswordNotEnteredException()
            : base("Error : Password Not Entered ")
        { }
    }


}