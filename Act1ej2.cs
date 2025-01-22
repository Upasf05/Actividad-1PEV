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
                Console.WriteLine("Pulse un boton para escoger una opcion");
                Console.WriteLine("1. Verificador de numero positivo o negativo. 2.Evaluar una nota. 3.Determinar rango de un numero");
                Console.WriteLine("4. Mostrar un dia de la semana. 5.Calculadora express. 6.Salir del programa.");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6) //Bucle while que valida entrada e impide un error.
                {
                    Console.WriteLine("Por favor, ingrese una opción valida (1-6):");
                }

                switch (opcion) //Switch del programa
                {
                    case 1: //Ejercicio 1
                        Console.Write("Ingrese un número: "); //Determinar si un numero es positivo, negativo o cero.
                        if (double.TryParse(Console.ReadLine(), out double numero)) //Funcion TryParse evita errores en casi cualquier conversion.
                        {
                            if (numero > 0)
                                Console.WriteLine("El numero es positivo.");
                            else if (numero < 0)
                                Console.WriteLine("El numero es negativo.");
                            else
                                Console.WriteLine("El numero es cero.");
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
                            Console.WriteLine("Ingrese un numero valido.");
                            break;
                        }

                        Console.Write("Ingrese el limite superior: ");
                        if (!double.TryParse(Console.ReadLine(), out double limiteSuperior) || limiteSuperior <= limiteInferior)
                        {
                            Console.WriteLine("Entrada invalida para el limite superior. El limite superior debe ser mayor que el inferior.");
                            break;
                        }

                        Console.Write("Ingrese un numero para determinar su rango: ");
                        if (double.TryParse(Console.ReadLine(), out double rangoNumero))
                        {
                            if (rangoNumero < limiteInferior)
                            {
                                Console.WriteLine($"El numero es menor que {limiteInferior}.");
                            }
                            else if (rangoNumero >= limiteInferior && rangoNumero <= limiteSuperior)
                            {
                                Console.WriteLine($"El numero esta en un rango intermedio.");
                            }
                            else
                            {
                                Console.WriteLine($"El numero es mayor que {limiteSuperior}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }
                        break;

                    case 4: //Ejercicio 4
                        Console.Write("Ingrese un numero del 1 al 7 para obtener un dia de la semana: "); //Obtener un dia de la semana
                        if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 7)
                        {
                            string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
                            Console.WriteLine($"Ha obtenido el dia: {diasSemana[dia - 1]}.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero valido del 1 al 7.");
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
                                        Console.WriteLine("Operacion no valida.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no valida para el segundo numero.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no valida para el primer numero.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Cerrando programa");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
