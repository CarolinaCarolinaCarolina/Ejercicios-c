﻿using Ejercicios__c.Parte_2;
using Ejercicios__c.Parte_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija la parte del ejercicio a buscar");
            int opcion = int.Parse(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 2:
                        Ejer e1 = new Ejer();
                        e1.Ejecucion();
                        break;
                    case 3:
                        Ejer3 e3 = new Ejer3();
                        e3.Ejecucion();
                        break;
                }
            } while (opcion != 3);
    }
    }
}
