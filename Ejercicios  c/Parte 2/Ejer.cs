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
                    case 3:
                        Ejer3();
                        break;
                    case 4:
                        Ejer4();
                        break;
                    case 5:
                        Ejer5();
                        break;
                    case 6:
                        Ejer6();
                        break;
                    case 7:
                        Ejer7();
                        break;
                    case 8:
                        Ejer8();
                        break;
                    case 9:
                        Ejer9();
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
        public static void Ejer4()
        {
            Console.WriteLine("Ingrese la cantidad de horas trabajadas");
            int horas = int.Parse(Console.ReadLine());
            if(horas <= 40)
            {
                int totalSalario = horas * 10000;
                Console.WriteLine("El total a pagar será" + totalSalario);
            }else if (horas > 40)
            {
                int horasExtras = horas - 40;
                int horasNormales = horas - horasExtras;
                int totalSalario = (horasNormales * 10000) + (horasExtras * 15000);
                Console.WriteLine("El total a pagar será" + totalSalario);
            }
        }
        public static void Ejer5()
        {
            Console.WriteLine("Ingrese la activdad que realizó");
            String actividad = Console.ReadLine().ToUpper();
            if (actividad.Equals("DORMIR"))
            {
                Console.WriteLine("ingrese el tiempo (en minutos) que realizó la actividad");
                double minutos = double.Parse(Console.ReadLine());
                double calorias = 1.08;
                double totalCarolias = calorias * minutos;
                Console.WriteLine("El total de calorias quemadas es :" + totalCarolias);
            }else if (actividad.Equals("SENTADO"))
            {
                Console.WriteLine("ingrese el tiempo (en minutos) que realizó la actividad");
                double minutos = double.Parse(Console.ReadLine());
                double calorias = 1.66;
                double totalCarolias = calorias * minutos;
                Console.WriteLine("El total de calorias quemadas es :" + totalCarolias);
            }
        }
        public static void Ejer6()
        {
            Console.WriteLine("Ingrese el valor de compra");
            double valor = double.Parse(Console.ReadLine());
            if (valor >= 5000000)
            {
                double PagarEllos = valor * 0.55;
                double PrestamoBanco = valor * 0.30;
                double CreditoEmpresa = valor * 0.15;
                double interes = CreditoEmpresa + (CreditoEmpresa * 0.15);
                Console.WriteLine($"El valor que deberá pagar la empresa es: {PagarEllos}\n" +
                    $"El valor que deberán prestar al banco será de: {PrestamoBanco}\n" +
                    $"El valor que deberán solicitas como credio a la empresa será de: {CreditoEmpresa}" +
                    $"El valor a pagar a la empresa con los intereses sería de: {interes}");
            }else if (valor< 5000000)
            {
                double PagarEllos = valor * 0.70;
                double CreditoEmpresa = valor * 0.30;
                double interes = CreditoEmpresa + (CreditoEmpresa * 0.15);
                Console.WriteLine($"El valor que deberá pagar la empresa es: {PagarEllos}\n" +
                    $"El valor que deberán solicitar como credio a la empresa será de: {CreditoEmpresa}" +
                    $"El vaor a pagar a la empresa con los intereses sería de: {interes}");
            }
        }
        public static void Ejer7()
        {
            Console.WriteLine("Ingrese el numero total de cuadernos");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 5)
            {
                int total = numero * 2000;
                Console.WriteLine("El total a pagar será: " + total);
            }else if (numero < 5)
            {
                int total = numero * 2500;
                Console.WriteLine("El total a pagar será: " + total);
            }
        }
        public static void Ejer8()
        {
            Console.WriteLine("Digite el total de ingresos del comprador");
            double ingresos = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la vivienda");
            double ValorVivienda = double.Parse(Console.ReadLine());
            if (ingresos>= 1200000)
            {
                double CuotaInicial = (ValorVivienda * 0.15);
                double CuotaSinInteres = (ValorVivienda - CuotaInicial) / 120;
                double CuotaConInteres = CuotaSinInteres + (CuotaSinInteres * 0.02);
                Console.WriteLine($"El valor de la vivienda es: {ValorVivienda}" +
                    $"El valor de la cuota inicial es: {CuotaInicial}" +
                    $"El valor de la cuota sin interes es: {CuotaSinInteres}" +
                    $"El valor de la cuota con interes es: {CuotaConInteres}");
            }else if (ingresos< 1200000)
            {
                double CuotaInicial = (ValorVivienda * 0.30);
                double CuotaSinInteres = (ValorVivienda - CuotaInicial) / 84;
                double CuotaConInteres = CuotaSinInteres + (CuotaSinInteres * 0.01);
                Console.WriteLine($"El valor de la vivienda es: {ValorVivienda}" +
                   $"El valor de la cuota inicial es: {CuotaInicial}" +
                   $"El valor de la cuota sin interes es: {CuotaSinInteres}" +
                   $"El valor de la cuota con interes es: {CuotaConInteres}");
            }
        }
        public static void Ejer9()
        {
            Console.WriteLine("Ingrese el numero");
            int numero = int.Parse(Console.ReadLine());
            int par = numero / 2;
            if (par == 0)
            {
                Console.WriteLine(numero*numero*numero);
            }
            else
            {
                Console.WriteLine(numero*3);
            }
        }
    }
}
