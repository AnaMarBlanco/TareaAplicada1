using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_1
{
    class Capitulo3
    {
        
        static void Main(String[] args)
        {//ejercicio 1 programa para saber si un numero es par o impar
            int numero=0;
            Console.WriteLine("Dime un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Es par");
            if (numero%2==0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

            //Ejercicio 4 Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.

            int dia;
            Console.WriteLine("Dime un numero: ");
            dia = Convert.ToInt32(Console.ReadLine());
            switch(dia)
            {
                case 1:
                    Console.WriteLine("es lunes");
                    break;
                case 2:
                    Console.WriteLine("es martes");
                    break;
                case 3:
                    Console.WriteLine("es miercoles");
                    break;
                case 4:
                    Console.WriteLine("es jueves");
                    break;
                case 5:
                    Console.WriteLine("es viernes");
                    break;
                case 6:
                    Console.WriteLine("es sabado");
                    break;
                default:
                    Console.WriteLine("es domingo");
                    break;
            }
        }
    }
}
