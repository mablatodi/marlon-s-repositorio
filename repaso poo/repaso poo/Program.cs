using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace repaso_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ruedas = 4;
            int ventanas = 4;
            string tapiceria = "tela";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int numcar = 0;
            string texto1 = "hola, cuantos carros quieres";
            int x1 =( Console.WindowWidth - texto1.Length)/2;
            Console.SetCursorPosition(x1, 1);
            Console.WriteLine(texto1);

            try
            {
                numcar = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("introduzca un numero valido");
                Console.ReadKey();
            }
            Console.WriteLine("\n");


            for (int i = 0; i < numcar; i++)
            {
                Console.WriteLine("vamos a armar tu carro numero " + (i + 1));
                Console.WriteLine("\n");

                carro carro = new carro();
                Console.WriteLine("numero de llantas");
                try
                {
                    ruedas = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("formato no valido, escriba un numero entero\nse le dejaran 4 llantas");
                }
                carro.setRuedas(ruedas);

                Console.WriteLine("numero de ventanas");
                try
                {
                    ventanas = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    Console.WriteLine("formato no valido, escriba un numero entero\nse le dejaran 4 ventanas");
                }
                carro.setVentanas(ventanas);

                Console.WriteLine("qué tapiceria");
                try
                {
                    tapiceria = Console.ReadLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("formato no valido,se le dejara tela");
                }
                finally//ejecuta el codigo independientemente si hay un error o no del bloque try catch
                {
                    Console.WriteLine("bloque finally");
                    carro.setTapiceria(tapiceria);
                    Console.WriteLine("\n");

                    Console.WriteLine($"tu carro numero {i + 1} tiene lo siguiente:\n");
                    Console.WriteLine(carro.getInfo());
                    Console.WriteLine("\n");

                    Console.WriteLine("presiona una tecla para continuar");
                    Console.WriteLine("\n");
                    Console.ReadKey();

                    Console.Clear();
                }

            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            string salida = "GRACIAS POR USAR EL PROGRAMA";

            int x = (Console.WindowWidth-salida.Length)/2;
            int y = (Console.WindowHeight)/2;

            Console.SetCursorPosition(x, y);

            Console.WriteLine(salida);

        }

        class carro
        {
            public string getInfo()
            {
                return "el auto que usted escogio tiene:\nruedas: " + ruedas + "\nventanas: " + ventanas + "\ntapiceria: " + tapiceria;
            }

            public carro(int ruedas, int ventanas)
            {
                this.ruedas = ruedas; //el this hace que c# sepa que thi.ruedas sepa que se habla de las ruedas
                                      //que aparecen en la clase osea private int ruedas, osea
                                      // this.ruedas=private int ruedas
                this.ventanas = ventanas;
            }
            public carro()
            {
                ruedas = 4;
                tapiceria = "cuero";
                ventanas = 4;
            }

            public void setRuedas(int ruedas)
            {
                this.ruedas = ruedas;
            }
            public void setVentanas(int ventanas)
            {
                this.ventanas = ventanas;
            }
            public void setTapiceria(string tapiceria)
            {
                this.tapiceria = tapiceria;
            }

            public int getRuedas()
            {
                return ruedas;
            }
            public string getTapiceria()
            {
                return tapiceria;
            }

            public int getVentanas()
            {
                return ventanas;
            }

           

            private int ruedas;
            private string tapiceria;
            private int ventanas;

        }

    }
}
