using System;
using System.Collections;

namespace pila_connumerosingresados_por_el_usuario
{
    public class Program
    {
        public static void Main()
        {
            int numero = 0, numeros = 0;
            Stack miPila = new Stack();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero Entero:");
                numero = Convert.ToInt32(Console.ReadLine());
                miPila.Push(numero);
                

            }
               Console.WriteLine("Los numeros ingresados son:");
            for (int i = 0; i < 5; i++)
            {
                numeros = (int)miPila.Pop();
                Console.WriteLine(numeros);
                

            }
            Console.ReadKey();
        }
    }
}
