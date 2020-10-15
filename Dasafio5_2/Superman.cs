using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasafio5_2
{
    class Superman : Superheroe, IVolador
    {
        int xp;
        public void Volador()
        {
            xp += 3;
            Console.WriteLine("Estoy volando como un campeón");
        }
    }
}
