using System;

namespace EjerciciosConSwitch
{
    class Program //Clase donde se ejecuta el programa
    {
        static void Main(string[] args)
        {
            int opcion; // Variable para seleccionar la opción del menu
            do
            {
                Console.WriteLine("TAREA 1, EJERCICIO 2");
                Console.WriteLine("PATRICIO SUAREZ, PROGRAMACION ESTRUCTURADA Y VISUAL");
                Console.WriteLine("Pulse un boton para escojer una opcion");
                Console.WriteLine("1. Verificador de numero positivo o negativo. 2.Evaluar una nota. 3.Determinar rango de un numero");
                Console.WriteLine("4. Mostrar un dia de la semana. 5.Calculadora express. 6.Salir del programa.");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6) //Bucle while que valida entrada e impide un error.
                {
                    Console.WriteLine("Por favor, ingrese una opción válida (1-6):");
                }

                switch (opcion) //Switch del programa
                {
                    case 1: //Ejercicio 1
                        Console.Write("Ingrese un número: "); //Determinar si un numero es positivo, negativo o cero.
                        if (double.TryParse(Console.ReadLine(), out double numero)) //Funcion TryParse evita errores en casi cualquier conversion.
                        {
                            if (numero > 0)
                                Console.WriteLine("El número es positivo.");
                            else if (numero < 0)
                                Console.WriteLine("El número es negativo.");
                            else
                                Console.WriteLine("El número es cero.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no valida.");
                        }
                        break;

                    case 2: //Ejercicio 2
                        Console.Write("Ingrese una nota entre 0 y 10: "); //Evaluar una nota
                        if (int.TryParse(Console.ReadLine(), out int calificacion) && calificacion >= 0 && calificacion <= 10)
                        {
                            if (calificacion >= 7)
                                Console.WriteLine("Felicidades, aprobo.");
                            else
                                Console.WriteLine("Se quedo en supletorio.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }
                        break;

                    case 3: //Ejercicio 3
                        Console.Write("Ingrese el límite inferior: ");
                        if (!double.TryParse(Console.ReadLine(), out double limiteInferior))
                        {
                            Console.WriteLine("Entrada inválida para el límite inferior. Intente de nuevo.");
                            break;
                        }

                        Console.Write("Ingrese el límite superior: ");
                        if (!double.TryParse(Console.ReadLine(), out double limiteSuperior) || limiteSuperior <= limiteInferior)
                        {
                            Console.WriteLine("Entrada inválida para el límite superior. El límite superior debe ser mayor que el inferior.");
                            break;
                        }

                        Console.Write("Ingrese un número para determinar su rango: ");
                        if (double.TryParse(Console.ReadLine(), out double rangoNumero))
                        {
                            if (rangoNumero < limiteInferior)
                            {
                                Console.WriteLine($"El número es menor que {limiteInferior}.");
                            }
                            else if (rangoNumero >= limiteInferior && rangoNumero <= limiteSuperior)
                            {
                                Console.WriteLine($"El número está entre {limiteInferior} y {limiteSuperior}.");
                            }
                            else
                            {
                                Console.WriteLine($"El número es mayor que {limiteSuperior}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                        }
                        break;

                    case 4: //Ejercicio 4
                        Console.Write("Ingrese un número del 1 al 7: "); //Obtener un dia de la semana
                        if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 7)
                        {
                            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                            Console.WriteLine($"El día de la semana es: {diasSemana[dia - 1]}.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Ingrese un número del 1 al 7.");
                        }
                        break;

                    case 5: //Ejercicio 5
                        Console.Write("Ingrese un numero: "); //Pedir el primer numero
                        if (double.TryParse(Console.ReadLine(), out double num1)) //Pedir el segundo numero
                        {
                            Console.Write("Ingrese otro numero: "); //Pedir el tercer numero
                            if (double.TryParse(Console.ReadLine(), out double num2)) //Pedir el cuarto numero
                            {
                                Console.Write("Ingrese la operacion a realizar (+, -, *, /): "); //Pedir el tipo de operacion
                                char operacion = Console.ReadKey().KeyChar;
                                Console.WriteLine();

                                switch (operacion) //Switch operacional
                                {
                                    case '+':
                                        Console.WriteLine($"Resultado: {num1 + num2}");
                                        break;
                                    case '-':
                                        Console.WriteLine($"Resultado: {num1 - num2}");
                                        break;
                                    case '*':
                                        Console.WriteLine($"Resultado: {num1 * num2}");
                                        break;
                                    case '/':
                                        if (num2 != 0)
                                            Console.WriteLine($"Resultado: {num1 / num2}");
                                        else
                                            Console.WriteLine("No se puede dividir a 0.");
                                        break;
                                    default:
                                        Console.WriteLine("Operación no válida.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no valida para el segundo número.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no valida para el primer número.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 6);
        }
    }
}