using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_4IT_WP_VP
{
    internal class ConnectionException : Exception
    {
        public ConnectionException()
        {

        }
        public ConnectionException(string message) : base(message)
        {

        }
    }
}
