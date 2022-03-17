using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Enum
{
    internal class Program
    {

        enum zoologico {aves,salvajes,mar,domesticos};
        static void Main(string[] args)
        {
            zoologico animales = zoologico.mar;

            if (animales == zoologico.aves)
            {
                Console.WriteLine("El zoologico tiene aves");
            }if (animales == zoologico.salvajes)
            {
                Console.WriteLine("El zoologico tiene animales salvajes");
            }
            if (animales == zoologico.domesticos)
            {
                Console.WriteLine("El zoologico tiene animales Domesticos");
            }
            if (animales == zoologico.mar)
            {
                Console.WriteLine("El zoologico tiene animales de mar");
            }


            Console.ReadKey();


        } 

    }
}
