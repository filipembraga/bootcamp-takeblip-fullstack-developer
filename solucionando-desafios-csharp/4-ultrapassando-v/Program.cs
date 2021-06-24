using System;

namespace _4_ultrapassando_v
{
    class Program
    {
        static void Main(string[] args)
        {
            var R = int.Parse(Console.ReadLine());
            var V = 0;
            var valoresSomados = 0;
            var qtdNumerosSomados = 1;

            do {

            V = int.Parse(Console.ReadLine());

            } while ( R >= V );

            for (valoresSomados = R; valoresSomados <= V; qtdNumerosSomados++) {
                R = R + 1;
                valoresSomados = valoresSomados + R;
            }
            Console.WriteLine(qtdNumerosSomados);
        }
    }
}
