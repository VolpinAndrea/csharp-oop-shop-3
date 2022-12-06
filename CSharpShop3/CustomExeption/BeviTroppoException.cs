using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3.CustomExeption
{
    internal class BeviTroppoException : Exception
    {
        public BeviTroppoException() : base()
        {

        }

        public BeviTroppoException(string message) : base(message)
        {

        }
    }
}
