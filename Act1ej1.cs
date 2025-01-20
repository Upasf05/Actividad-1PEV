using System;

namespace EjerciciosBasicos
{
    class Program // Clase donde se ejecuta el programa.
    {
        static void Main(string[] args) //Metodo que permite la ejecucion del programa
        {
            int opcion; // Variable común para seleccionar la opción del menú
            int input;  // Variable común para usar en los bucles
            int suma;   // Variable común para cálculos de suma

            do
            {
                Console.WriteLine("TAREA 1, EJERCICIO 1");
                Console.WriteLine("PATRICIO SUAREZ, PROGRAMACION ESTRUCTURADA Y VISUAL");
                Console.WriteLine("Pulse un boton para escojer una opcion");
                Console.WriteLine("1. Imprimir los numeros pares del 1 al 100. 2. Imprimir los numeros del 1 al 50. 3. Imprimir los numeros del 1 al 10");
                Console.WriteLine("4. Imprimir suma de los primeros 100 numeros. 5. Imprimir los numeros pares del 1 al 100. ");
                Console.WriteLine("Si elige la opcion 3 aparecera Fizz para numeros divisibles por 3 y Buzz para numeros divisibles por 5,o FizzBuzz en los que sean divisibles por ambos. ");
                Console.WriteLine("Este menu reaparecera cada que finalice una operacion. Si desea terminar pulse 6.");
                opcion = Convert.ToInt32(Console.ReadLine()); //Se usa INT32 para la lectura de este valor porque si no el codigo dara error.

                switch (opcion) //Switch para seleccion de multiples opciones.
                {
                    case 1: //Opcion 1
                        Console.WriteLine("Números pares (1 al 100):");
                        for (input = 2; input <= 100; input += 2) //Imprimir numeros pares del 1 al 100 sin usar un bucle if.
                        {
                            Console.WriteLine(input);
                        }
                        break;

                    case 2: //Opcion 2
                        Console.WriteLine("FizzBuzz (1 al 50):"); //Imprimir numeros del 1 al 50.
                        for (input = 1; input <= 50; input++)
                        {
                            if (input % 3 == 0 && input % 5 == 0) //Opciones personalizadas.
                            {
                                Console.WriteLine("FizzBuzz"); //Fizzbuzz para  de 3 y 5.
                            }
                            else if (input % 3 == 0)
                            {
                                Console.WriteLine("Fizz"); //Fizz para dividendos de 3.
                            }
                            else if (input % 5 == 0)
                            {
                                Console.WriteLine("Buzz"); //Buzz para dividendos de 5.
                            }
                            else
                            {
                                Console.WriteLine(input);
                            }
                        }
                        break;

                    case 3: //Opcion 3
                        Console.WriteLine("Números (1 al 10 con while):"); //Imprimir numeros del 1 al 10.
                        input = 1;
                        while (input <= 10) //Utilizar un bucle while
                        {
                            Console.WriteLine(input);
                            input++;
                        }
                        break;

                    case 4: //Opcion 4
                        Console.WriteLine("La suma de los primeros 100 numeros es:"); //Suma de los primeros 100 enteros.
                        suma = 0;
                        input = 1;
                        while (input <= 100) //Utilizar un bucle while
                        {
                            suma += input;
                            input++;
                        }
                        Console.WriteLine("Suma: " + suma);
                        break;

                    case 5: //Opcion5   
                        Console.WriteLine("Números pares (1 al 100 con while):"); //Mostrar los numeros pares entre 1 y 100.
                        input = 2;
                        while (input <= 100)
                        {
                            Console.WriteLine(input); //Utilizar un bucle while
                            input += 2; //Mostrar pares.
                        }
                        break;

                    case 6: //Opcion para cerrar el programa.
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine(); // Espaciado entre iteraciones del menú
            } while (opcion != 6);
        }
    }
}