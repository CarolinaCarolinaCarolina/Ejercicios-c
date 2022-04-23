using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__c.Parte_2
{
    internal class Ejer
    {
        public void Ejecucion()
        {
            Console.WriteLine("Ingrese el numero del ejercisio");
            int numero = int.Parse(Console.ReadLine());
            do
            {
                switch (numero)
                {
                    case 1:
                        Ejer1();
                        break;
                    case 2:
                        Ejer2();
                        break;
                }
            } while (numero!=9);
        }
        public static void Ejer1()
        {
            Console.WriteLine("Ingrese el primer numer");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = double.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1);
                Console.WriteLine(numero2);
            }
            else
            {
                Console.WriteLine(numero2);
                Console.WriteLine(numero1);
            }
        }
        public static void Ejer2()
        {
            Console.WriteLine("Ingrese el numero");
            int numero = int.Parse(Console.ReadLine());
            int par = numero / 2;
            if (par == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        public static void Ejer3()
        {
            Console.WriteLine("Ingrese el sexo");
            String sexo = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese la edad");
            int edad = int.Parse(Console.ReadLine());
            if (sexo.Equals("MASCULINO"))
            {
                int numpulsaciones = (210 - edad) / 10;
                Console.WriteLine("El numero de pulsaciones deberia ser igual a: " + numpulsaciones);
            }
            else if (sexo.Equals("FEMENINO"))
            {
                int numpulsaciones = (220 - edad) / 10;
                Console.WriteLine("El numero de pulsaciones deberia ser igual a: " + numpulsaciones);
            }
        }
    }
}
