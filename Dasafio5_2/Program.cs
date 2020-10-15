using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasafio5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl t = new TorreDeControl();

            Console.WriteLine("Presione cualquier tecla para agregar un pato, un boing747 y a superman a las alturas");
            Console.ReadKey();
            t.agregarVolador();
            Console.WriteLine("Se han liberado a los cielos");
            Console.WriteLine("Presione cualquier tecla para mostrar el pensamiento de cada uno durante el vuelo");
            Console.ReadKey();
            t.vuelenTodos();

            Console.ReadLine();
        }
    }
}
