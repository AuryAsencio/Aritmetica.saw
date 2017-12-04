using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetica_Saw
{
    class Program
    {
        public static double n { get; private set; }

        static void Main(string[] args)
        {

            /*PROGRAMA QUE REALIZA LA SUMATORIA DE 5 NUMEROS Y CALCULA LA POTENCIA DESEADA DE LOS NUMEROS DEL 1 AL 15*/

        
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("PROGRAMACION ESTRUCTURADA O&M 0463");
            Console.WriteLine(     "INGENIERIA INDUSTRIAL"        );

            Console.WriteLine("SARAH LARA           16-SIIT-1-073");
            Console.WriteLine("AURY ASENCIO         16-SIIT-1-074");
            Console.WriteLine("WALTER REYNOSO       16-SIIT-1-096");



            //DECLARACION DE VALORES Y CONVERSION ENTRE TIPO
            Console.ForegroundColor = ConsoleColor.White;
            int h1, h2, h3, h4, h5 = 0;
            Console.WriteLine("INGRESE EL PRIMER VALOR");
            int.TryParse(Console.ReadLine(), out h1);
            Console.WriteLine("INGRESE EL SEGUNDO VALOR");
            int.TryParse(Console.ReadLine(), out h2);
            Console.WriteLine("INGRESE EL TECERR VALOR");
            int.TryParse(Console.ReadLine(), out h3);
            Console.WriteLine("INGRESE EL CUARTO VALOR");
            int.TryParse(Console.ReadLine(), out h4);
            Console.WriteLine("INGRESE EL QUINTO VALOR");
            int.TryParse(Console.ReadLine(), out h5);

            //HAREMOS LA SUMA DE LOS VALORES QUE LE USARIO HA INGRESADO

            int sum = 0;
            sum = (h1 + h2 + h3 + h4 + h5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("LA SUMA DIO COMO RESULTADO: " + sum.ToString());
            
            //CONDICION IF 

            if (sum <=100)
            {
                Console.WriteLine("FELICIDADES CUMPLES LA CONDICION");    
            }
            else if (sum >=101)
            {
                Console.WriteLine("LAMENTABLEMENTE NO CUMPLES CON LA CONDICION, LA SUMATORIA ES MAYOR A 100");
            }

            // BUCLE for  DE POTENCIAS

            int p = 1;

            Console.WriteLine("INTRODUCE LA POTENCIA A LA CUAL DESEAS ELEVAR");
            int.TryParse(Console.ReadLine(), out p);

            for (int n = 1; n <= 15; n++)
                
            {
              
                double m = Math.Pow(n, p);
                
                Console.ForegroundColor = ConsoleColor.White;
                
                Console.WriteLine(n + " ^ " + p + " = " + m);
                
            }

            // ENTRADA POR TECLADO

            string c;
            Console.WriteLine("¿LE GUSTO EL PROGRAMA AL PROFESOR?");
            c = Console.ReadLine();
            Console.WriteLine("CIAO, SU RESPUESTA FUE: " + c);

            Console.ReadKey();

            /*Hecho por:
         *Sarah lara       16-SIIT-1-073  Seccion 0463
         * Aury Asencio    16-SIIT-1-074  Seccion 0463
         * Walter Reynoso  16-SIIT-1-096  Seccion 0463 */
            
             


























        }
    }
}
