using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class AnException:Exception
    {
        public AnException():base ()
        {

        }
        public AnException(string message):base (message)
        {

        }

        public AnException(string message, Exception innerException):base (message, innerException) { }
        
    }
}
