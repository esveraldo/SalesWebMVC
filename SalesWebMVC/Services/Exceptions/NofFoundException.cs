using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class NofFoundException : ApplicationException
    {
        public NofFoundException(string message) : base(message)
        {

        }
    }
}
