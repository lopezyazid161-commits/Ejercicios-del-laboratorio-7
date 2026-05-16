using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordCorrecta = "UPN2026";
            string passwordIngresada;
            int intentos = 0;
            const int MAX_INTENTOS = 3;
            bool acceso = false;

            do
            {
                Console.Write("Ingrese su contraseña: ");
                passwordIngresada = Console.ReadLine();
                intentos++;

                if (passwordIngresada == passwordCorrecta)
                {
                    acceso = true;
                }
                else
                {
                    int restantes = MAX_INTENTOS - intentos;
                    if (restantes > 0)
                    {
                        Console.WriteLine($"Contraseña incorrecta. Intentos restantes: {restantes}");
                    }
                }

            } while (!acceso && intentos < MAX_INTENTOS);

            if (acceso)
            {
                Console.WriteLine("Acceso concedido. Bienvenido.");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada. Contacte al administrador.");
            }
        }
    }
}
