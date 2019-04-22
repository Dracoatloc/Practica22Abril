using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica22Abril.Classes;

namespace Practica22Abril
{
    class Program
    {
        static void Main(string[] args)
        {
            ChecarMultiplos m = new ChecarMultiplos();
            m.leerArchivo();
            m.revisarMultiplos();
        }
    }
}
