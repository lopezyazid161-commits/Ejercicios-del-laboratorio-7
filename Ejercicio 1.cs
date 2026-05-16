using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subtotal = 0;
            int platos = 0;
            int opciones;

            do
            {
                Console.WriteLine("\n=== MENÚ DEL RESTAURANTE ===");
                Console.WriteLine("1. Lomo saltado - S/25.00");
                Console.WriteLine("2. Ceviche - S/30.00");
                Console.WriteLine("3. Ají de gallina - S/20.00");
                Console.WriteLine("4. Pollo a la brasa - S/35.00");
                Console.WriteLine("0. Pedir la cuenta");
                Console.WriteLine("Elija una opción");

                opciones = int.Parse(Console.ReadLine());

                if (opciones == 1)
                {
                    subtotal = subtotal + 25;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Lomo saltado");
                }
                else if (opciones == 2)
                {
                    subtotal = subtotal + 30;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Ceviche");
                }
                else if (opciones == 3)
                {
                    subtotal = subtotal + 20;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Ají de gallina");
                }
                else if (opciones == 4)
                {
                    subtotal = subtotal + 35;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Pollo a la brasa");
                }
                else if (opciones != 0)
                {
                    Console.WriteLine("Opción no válida");
                }
            } while (opciones != 0);
            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            Console.WriteLine("\n=== CUENTA ===");
            Console.WriteLine($"Platos pedidos: {platos}");
            Console.WriteLine($"Subtotal: S/{subtotal}");
            Console.WriteLine($"IGV(18%): S/{igv}");
            Console.WriteLine($"TOTAL: S/{total}");
        }
    }
}
