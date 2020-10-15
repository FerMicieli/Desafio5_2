using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasafio5_2
{
    class Boing747 : Avion, IVolador
    {
        int horasdevuelo;
        public void Volador()
        {
            horasdevuelo += 13;
            Console.WriteLine("Estoy volando como un avion");
        }
    }
}
