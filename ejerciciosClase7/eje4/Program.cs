using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int vocal;
            Console.WriteLine('ingrese una vocal');
            vocal = int.Parse(Console.ReadLine());

            switch (vocal)
            {
                case 'a':
                {
                    Console.WriteLine('A');
                }break;
                default:
                    Console.WriteLine('es una consonante');
                    break;

            }
            //Console.WriteLine("Hello World!");
        }
    }
}
