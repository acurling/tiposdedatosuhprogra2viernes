using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tiposdedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos

            int num1, num2;   
            
            byte b = 36;
            short s = 69;
            long largo = 9999945874;
            float flotante = 3.14f;
            double doble = 365.2555d;
            decimal deci = 366.56m;
            bool boleana = false;
            string cadena = "Hola mundo";
            char caracter = 'a';

            var variable = 20;
            variable = 30;

            dynamic dinamica = false;
            dinamica = 20;
            dinamica = "hola mundo";
            dinamica = 'a';

            num1 = 20;
            num2 = 5;
            Console.WriteLine(num1);
            Console.WriteLine(num1*num2);
            Console.WriteLine("La division es:" + num1/num2);
            Console.WriteLine("La division es: {0}", num1/num2);
            // pasar valores po referencia
            Console.WriteLine("La resta de {0}-{1} es: {2}",num1,num2,num1-num2);
            // pasar valores por interpolacion
            Console.WriteLine($"la suma de {num1}+{num2} es:{(num1+num2)}");
            Console.WriteLine("Digite su nombre:");
            string nombre = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Gracias {nombre} desea hacer un prestamo");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el monto:");
            // convertir el monto de string a flotante
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite los meses:");
            //convertir los meses de string integer
            int mes = int.Parse(Console.ReadLine());
           float resultado = (monto / mes);
            Console.Write($"Su cuota mensual es de {resultado}");
            Console.Write($",Puedo hacer algo mas por usted {nombre}?");

            Console.ReadLine();
        }
    }
}

