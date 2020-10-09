using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Core.Exception
{
    public class UnauthorisedException : System.Exception
    {
        public UnauthorisedException() : this("Unauthorised")
        {

        }

        public UnauthorisedException(string message) : base(message)
        {
        }
    }
}
