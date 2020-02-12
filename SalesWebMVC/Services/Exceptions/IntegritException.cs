﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegritException : ApplicationException
    {
        public IntegritException(string message) : base(message)
        {

        }
    }
}
