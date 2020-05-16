using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace tarea_1
{
    class Capitulo2
    {
        static void Main(String[] args)
        {   //Ejercicio 1 cre un programa que calcule el perimetro de una figura regular
            double tam = 0, res = 0;
            int cantidad = 0;
            Console.WriteLine("Cuantos lados tiene la figura: ");
           
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantos mide cada lado: "); 
            tam = Convert.ToDouble(Console.ReadLine());
            //formula
            res = tam * cantidad;
            Console.Out.WriteLine("Resultado: "+res);

            //ejercicio 3 cree prgrama que calcule de grados a radiane
            int grad;
            float radia;
            float res1;
          
            Console.WriteLine("cuantos radianes tiene?");

            //ejercicio 4 cree un programa que calcule de farenhait a celsius

            double f;
            double c; 
            Console.WriteLine("escribe cantidad de farenhait");//si 
            f = Convert.ToDouble(Console.ReadLine());
            c = f - 32 / 1.8000;
            Console.Out.WriteLine("Celcius: "+c);

            //ejercicio 5
            
            double dolares, euros, valorEuro;
            Console.WriteLine("escribe cantidad de dolares: ");
            dolares = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor del euro: ");
            valorEuro =Convert.ToDouble(Console.ReadLine());
            euros = valorEuro * dolares;
            Console.WriteLine("Euros: "+euros);
            






        }
    }
}
