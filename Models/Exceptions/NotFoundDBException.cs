using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Exceptions
{
    public class NotFoundDBException : Exception
    {
        public NotFoundDBException(string Message) : base(Message)
        { 
        
        }
    }
}
