using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Core.Exception
{
    public class BadRequestException : System.Exception
    {
        public BadRequestException() : this("Badrequest")
        {

        }

        public BadRequestException(string message) : base(message)
        {
        }
    }
}
