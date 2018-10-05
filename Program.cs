using System;

namespace suma_de_multiplos_de_3_y_5_gtesistemas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, introduce el numero tope para para suma de múltiplos de 3 y 5:");
            int tope = int.Parse(Console.ReadLine());
            int suma3y5=0;

            Console.WriteLine("El número N es: {0}",tope);

            for (int i=0;i<=tope;i++)
                if ((i % 3 == 0) || (i % 5 == 0))
                    suma3y5 = suma3y5+i;
            Console.WriteLine("La suma es {0}",suma3y5);
            Console.ReadLine();
        }
    }
}
