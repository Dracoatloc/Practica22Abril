using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica22Abril.Classes
{
    class ChecarMultiplos
    {
        List<string> list = new List<string>();
        public void leerArchivo()
        {
            string[] mltpls = File.ReadAllLines(@"C:\Users\mtorr\source\repos\NewRepo3\Practica22Abril\Practica22Abril\ArchivoMultiplos.txt");

            for (int i = 0; i < mltpls.Count(); i++)
            {
                string templete = mltpls[i];

                string[] mltpls2 = templete.Split('\t');
                
                for(int x = 0; x < mltpls2.Count(); x++)
                {
                    list.Add(mltpls2[x]);
                }
            }
        }

        public void revisarMultiplos()
        {
            int contador = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                int z = Int32.Parse(list[i]);

                if (z % 10 == 0)
                {
                    contador++;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("La cantidad de multiplos de 10 es: {0}.", contador);
            Console.ReadKey();

        }
    }
}
