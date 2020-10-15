using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasafio5_2
{
    class Pato : Animal, IVolador
    {
        int energia;
        public void Volador()
        {
            energia -= 5;
            Console.WriteLine("Estoy volando como un pato ... ¡Cuak!");
        }
    }
}
