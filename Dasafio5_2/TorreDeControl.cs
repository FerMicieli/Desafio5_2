using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasafio5_2
{
    class TorreDeControl
    {
        List<IVolador> voladores = new List<IVolador>();

        public void vuelenTodos()
        {
            foreach (IVolador a in voladores)
            {
                a.Volador();
            }
        }

        public void agregarVolador()
        {
            Pato p = new Pato();
            voladores.Add(p);

            Boing747 b = new Boing747();
            voladores.Add(b);

            Superman s = new Superman();
            voladores.Add(s);

        }
    }
}
