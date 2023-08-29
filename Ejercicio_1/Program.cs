using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primero: Declaramos nuestras variables
            float c=0.0f, f=0.0f;
            Console.Write("ingrese la temperatura en grados Fahrenheint: ");
            f = Convert.ToSingle(Console.ReadLine()); //Capturamos el dato ingresado por consola y lo convertimos en float 
            c = (f - 32) * 5 / 9; //Realizamos el calculo de la comversion de los grados Fahrenheint en grados Celcius
            Console.WriteLine("La temperatura equivalente de {0} grados Fahrenheint en Celcius es: {1}",f,c);//Imprimimos en pantalla los resultados 
            Console.ReadKey();


        }
    }
}
