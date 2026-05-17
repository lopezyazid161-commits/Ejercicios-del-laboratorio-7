using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace trabajo_semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo01();
            //ejemplo02();
            //ejemplo03();
            //ejercicio01();
            //ejercicio02();
            //--------tarea (mi parte)---------
            //ejercicio05();
            ejercicio06();


        }
        static void ejemplo01()
            //identificadores de multiplos
        {
            int i = 0;

            Console.Write("ingrese el un numero : ");
            int numero = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(i);
                i = +i + numero;
            }
            while (i < 100);
        }
        static void ejemplo02()
            //sumas acumulativas
        {
            int numero;
            int suma = 0;

            do
            {
                Console.Write("ingrese un numero (0 para terminar)");
                numero = int.Parse(Console.ReadLine());

                suma += numero;
            } while (numero != 0);
            Console.WriteLine($"la suma total de numeros ingresados es de {suma}");
            Console.ReadLine();
        }
        static void ejemplo03()
        {
            string contraseña_C = "admin";
            string contraseña = "";

            while (contraseña != contraseña_C)
            {
                Console.Write("ingrese la contraseña : ");
                contraseña = Console.ReadLine();
                if (contraseña != contraseña_C)
                {
                    Console.WriteLine("contraseña incorrecta");
                }
                else
                {
                    Console.WriteLine("contraseña correcta");
                    break;
                }

            }
        }
        static void ejercicio01()
        {
            int C_numeros;
            int promedio = 0;
            int cantidad = 0;
            double valor_total;
            do
            {
                Console.Write("ingrese el numero a promediar (0 para salir) : ");
                C_numeros = int.Parse(Console.ReadLine());
                if (C_numeros != 0)
                {
                    cantidad++;
                    promedio += C_numeros;
                }
               

            } while (C_numeros != 0);

            valor_total = (double)promedio / cantidad;

            Console.Write($"el promedio total es {valor_total:F2}");

        }
        static void ejercicio02()
        {
            int numeros;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            Console.WriteLine("ingrese numeros enteros (999 para salir)");
            Console.Write("numeros : ");
            numeros = int.Parse(Console.ReadLine());
            
            while (numeros != 999)
            {
                if (numeros > 0)
                {
                    Console.WriteLine("positivo");
                    positivos++;
                }
                else if (numeros < 0)
                {
                    Console.WriteLine("negativos");
                    negativos++;
                }
                else
                {
                    Console.WriteLine("cero");
                    ceros++;
                }
                Console.Write("numeros : ");
                numeros = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\n resumen de resultados");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("postivos = " + positivos);
            Console.WriteLine("negativos = " + negativos);
            Console.WriteLine("ceros = " + ceros);
            Console.WriteLine("----------------------------------");

            Console.ReadKey();

            
        }
        static void ejercicio05() 
        {
            /*
            Reto integrador con estructura repetitiva Hacer Mientras / do-while, números aleatorios, 
            condición compuesta, acumuladores de puntaje y decisión múltiple.  Crear un juego de Piedra, 
            Papel o Tijera contra la computadora. 
            Las opciones son: 
            Opción Jugada 
            1       Piedra 
            2       Papel 
            3       Tijera  
            El juego se repite por rondas hasta que el jugador o la computadora llegue a 3 puntos. En cada ronda, 
            la computadora elige una opción al azar. Después de cada ronda, se debe mostrar el marcador. Al final, 
            se muestra el ganador del juego. 
            */

            Random rand = new Random();

            int puntaje_jugador = 0;
            int puntaje_PC = 0;
            int ronda = 0;

            do
            {
                ronda++;
                Console.WriteLine($"*------ RONDA{ronda} --------*");
                Console.WriteLine("elije tu arma");
                Console.WriteLine("1. papel");
                Console.WriteLine("2. tijera");
                Console.WriteLine("3. piedra");
                Console.Write("ingresar numero ----> : ");
                int arma = int.Parse(Console.ReadLine());

                int PC = rand.Next(1, 4);
                Console.WriteLine($"la PC elijio {PC} ");

                if (arma < 1 || arma > 3)
                {
                    Console.WriteLine("arma invalida. la ronda se anula");
                    ronda--;
                }
                else if (arma == PC)
                {
                    Console.WriteLine("empate");
                }
                else if (arma == 1 && PC == 3 || arma == 2 && PC == 1 || arma == 3 && PC == 2)
                {
                    Console.WriteLine("GANA EL JUGADOR");
                    Console.WriteLine("ganaste 100 puntos !!!");
                    puntaje_jugador = puntaje_jugador + 100;
                }
                else
                {
                    Console.WriteLine("GANA PC");
                    Console.WriteLine("PC gana 100 puntos !!!");
                    puntaje_PC = puntaje_PC + 100;
                }
                Console.WriteLine($"marcador --- TU puntaje {puntaje_jugador} ----- puntaje de PC {puntaje_PC}");
            }
            while (puntaje_jugador != 300 && puntaje_PC != 300);
            {
                if (puntaje_jugador == 300)
                {
                    Console.WriteLine("GANASTE :3 ");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("GANO LA PC :C");
                    Console.ReadLine();
                }
            }





        }
        static void ejercicio06()
        {
            /*
            Sistema de Votación Electrónica Tipo: Reto integrador con estructura repetitiva 
            Hacer Mientras / do-while, decisión múltiple, contadores y comparación de resultados.  
            En una elección hay 3 candidatos: 
            Opción Candidato 
            1       Ana Torres 
            2       Carlos Mendoza 
            3       Lucía Paredes 
            0       Cerrar votación 
            Los votantes ingresan su voto uno a uno. Si el voto es 1, 2 o 3, se suma al candidato 
            correspondiente. Si el voto es otro número diferente de 0, se considera voto nulo y se cuenta por separado. 
            Al ingresar 0, se cierra la votación. Al finalizar, el programa debe mostrar: 
            • votos de Ana Torres;  
            • votos de Carlos Mendoza;  
            • votos de Lucía Paredes;  
            • votos nulos;  
            • total de votantes;  
            • candidato 
            ganador o empate. 
            */

            int ana_torres = 0;
            int carlos_mendoza = 0;
            int lucia_paredes = 0;
            int nulos = 0;

            Console.WriteLine("---------- VOTOS ----------");
            Console.WriteLine("candidatos");
            Console.WriteLine("1. Ana Torres");
            Console.WriteLine("2. Carlos Mendoza");
            Console.WriteLine("3. Lucía Paredes");
            Console.WriteLine("0. Cerrar votación");
            Console.Write("ingrese su voto ------> : ");
            int voto = int.Parse(Console.ReadLine());

            do
            {
 

                if (voto == 1)
                {
                    Console.WriteLine("voto para Ana Torres");
                    ana_torres++;
                }
                else if (voto == 2)
                {
                    Console.WriteLine("voto para Carlos Mendoza");
                    carlos_mendoza++;
                }
                else if (voto == 3)
                {
                    Console.WriteLine("voto para Lucia Paredes");
                    lucia_paredes++;
                }
                else if (voto != 0)
                {
                    Console.WriteLine("voto nulo");
                    nulos++;
                }
                Console.Write("ingrese su voto ------> : ");
                voto = int.Parse(Console.ReadLine());
            }
            while (voto != 0);
            {
                int total_votos = ana_torres + carlos_mendoza + lucia_paredes;

                Console.WriteLine($"votos de Ana Torres {ana_torres}");
                Console.WriteLine($"votos de Carlos Mendoza {carlos_mendoza}");
                Console.WriteLine($"votos de Lucía Paredes {lucia_paredes}");
                Console.WriteLine($"votos nulos {nulos}");
                Console.WriteLine($"total de votantes {total_votos}");

                if (ana_torres > carlos_mendoza && ana_torres > lucia_paredes)
                {
                    Console.WriteLine("ganadora es Ana Torres");
                }
                else if (carlos_mendoza > ana_torres && carlos_mendoza > lucia_paredes)
                {
                    Console.WriteLine("ganador es Carlos Mendoza");
                }
                else if (lucia_paredes > ana_torres && lucia_paredes > carlos_mendoza)
                {
                    Console.WriteLine("ganadora es Lucia Paredes");
                }
                else
                {
                    Console.WriteLine("empate no ay ganadores");
                }
                Console.ReadLine();
            }
        }
    }
}

