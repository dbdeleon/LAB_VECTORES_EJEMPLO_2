using System;

namespace LAB_VECTORES_EJEMPLO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEGUNDO EJEMPLO VECTORES CON FUNCIONES!");
            pruebaVector pv = new pruebaVector();
            pv.Cargar();
            pv.Imprimir();
        }

        class pruebaVector
        {
            private int[] sueldos;
            public int suma = 0; 
            public void Cargar()
            {
                sueldos = new int[5];
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("Ingresa un salario: ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f] = int.Parse(linea);
                    suma = suma + sueldos[f];
                }
             }
            public void Imprimir()
            {
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine(""); 
                    Console.WriteLine("Se ingreso "); 
                    Console.WriteLine(sueldos[f] );
                }
                Console.WriteLine("La suma es : " + suma);
                Console.ReadKey();
            }

        }
    }
}
