using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKien.Utilities.Exceptions
{
    public class ShopException : Exception
    {
        public ShopException()
        {

        }

        public ShopException(string message):base(message)
        {

        }
        public ShopException(string message,Exception exception) : base(message,exception)
        {

        }
    }
}
