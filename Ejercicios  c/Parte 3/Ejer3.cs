using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__c.Parte_3
{
    internal class Ejer3
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
                    case 3:
                        //Ejer3();
                        break;
                    case 4:
                        //Ejer4();
                        break;
                }
            } while (numero != 4);
        }
        public static void Ejer1()
        {
            Console.WriteLine("Ingrese el numero");
            int numero = int.Parse(Console.ReadLine());
            int cont = 0;
            for (int i = 2; i <= numero; i++)
            {  //apertura del for1
                for (int j = 1; j <= i; j++)
                {   //apertura for2

                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }


                if (cont <= 2)
                { //si variable cont es mayor a dos, el numero es divisible en mas de dos numero osea no es primo
                    Console.WriteLine(i);
                }      //cierre for2
                cont = 0;               //igualamos a cero para hacer otra evaluacion con otro numero


            }//cierre del for1

        }
        public static void Ejer2()
        {
            
            Console.WriteLine("Ingrese la cantidad de sueldos");
            int cantidad = int.Parse(Console.ReadLine());
            int[] sueldos = new int[cantidad];
            int max = sueldos[0];
            for(int j = 0; j < cantidad; j++)
            {
                Console.WriteLine("Ingrese el sueldo: " + j);
                sueldos[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < cantidad; i++){
                if (sueldos[i] > max)
                {
                    max = sueldos[i];
                }
            }
            Console.WriteLine("El sueldo maximo es: " + max);
        }
    }
}
