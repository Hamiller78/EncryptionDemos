using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlgorithms.Exceptions
{
    internal class NoKeyFoundException : Exception
    {
        internal NoKeyFoundException(string message) : base(message) { }
        internal NoKeyFoundException(string message, Exception? innerException)
            : base(message, innerException) { }
    }
}
