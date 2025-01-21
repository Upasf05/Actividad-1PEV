using System;

public class Persona //Clase para persona
{
    public string nombre; //Atributos en valores int y string para cada clase que sera un objeto
    public int edad; //Int (entero) para edad
    public int dni; //Celula solo puede incluir numeros
    public void MostrarInformacion() //Metodo para probar y mostrar los nombres y edad
    {
        Console.WriteLine("Nombre: " + nombre + ", Edad: " + edad + ", DNI: " + dni); //Mostrar en pantalla los valores introducidos
    }
}

public class Punto //Clase para un punto de plano cartesiano
{
    public double x; //Coordenadas X y Y como atributos
    public double y; //Valores dobles (decimales), son ideales para coordenadas

    public void MostrarCoordenadas() //Metodo para probar y mostrar los valores de coordenada
    {
        Console.WriteLine("Punto en: (" + x + ", " + y + ")"); //Mostrar en pantalla los valores introducidos
    }
}

public class Circulo //Clase para un circulo
{
    public double x; //Coordeanadas que muestran la ubicacion del circulo
    public double y;
    public double radio; //Radio del circulo

    public double CalcularArea() //Metodo para calcular el area de circulo
    {
        return 3.14 * radio * radio; //Pi por radio al cuadrado
    }

    public void MostrarInformacion() //Metodo para probar y mostrar los valores
    {
        Console.WriteLine("Centro: (" + x + ", " + y + "), Radio: " + radio + ", Area: " + CalcularArea()); //Mostrar en pantalla los valores introducidos
    }
}

public class Persona2 //Segunda clase para persona
{
    public string nombre; //Nombre
    public string apellido; //Apellidos
    public int edad; //Edad
    public string genero; //Genero

    public void ImprimirInformacion() //Metodo para probar y mostrar los valores
    {
        Console.WriteLine("Nombre: " + nombre + " " + apellido + ", Edad: " + edad + ", Genero: " + genero); //Mostrar en pantalla los valores introducidos
    }
}

public class Program //Clase principal que muestra todos los atributos solicitados
{
    public static void Main(string[] args) //Metodo que muestra todos los objetos creados mediante clases con sus valores
    {
        Persona persona = new Persona();
        persona.nombre = "Luis";
        persona.edad = 35;
        persona.dni = 135792468;
        persona.MostrarInformacion(); //Utilizacion de metodos creados en las clases de objeto

        Punto punto = new Punto();
        punto.x = 3.5;
        punto.y = 7.2;
        punto.MostrarCoordenadas();

        Circulo circulo = new Circulo();
        circulo.x = 0; 
        circulo.y = 0;
        circulo.radio = 5;
        circulo.MostrarInformacion();

        Persona2 personaExt = new Persona2();
        personaExt.nombre = "Maria";
        personaExt.apellido = "Perez";
        personaExt.edad = 28;
        personaExt.sexo = "Femenino";
        personaExt.ImprimirInformacion();
    }
}
