using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class PlayerException : Exception
    {
        public PlayerException() : base() { }

        public PlayerException(string message) : base(message) { }

        public PlayerException(string message, Exception innerException) : base(message, innerException) { }
    }
}
