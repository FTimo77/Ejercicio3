using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args) //Método principal para llamar a los metodos de las clases
        {
            Persona persona = new Persona("Juan", 12345678, 25);
            persona.MostrarDatos();
            Console.ReadKey();
            PlanoCartesiano plano = new PlanoCartesiano("10", "20");
            plano.MostrarDatos();
            Console.ReadKey();
            circulo Circulo = new circulo(5, 2, 10);
            Circulo.MostrarDatos();
            Circulo.calcularArea();
            Console.ReadKey();
            Persona1 persona1 = new Persona1("Juan", "López", "20", "Masculino");
            persona1.MostrarDatos();
            Console.ReadKey();
        }
    }

    internal class Persona
    {
        public string Nombre { get; set; } //Declaración de los atributos
        public int Dni { get; set; }
        public int Edad { get; set; }
        public Persona(string nombre, int dni, int edad) //Método para darle valor a los atributos
        {
            Nombre = nombre;
            Dni = dni;
            Edad = edad;
        }
        public void MostrarDatos() //Método para mostrar los atributos
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Dni: " + Dni);
            Console.WriteLine("Edad: " + Edad);
        }
    }

    internal class PlanoCartesiano
    {
        public string X { get; private set; }//Declaración de los atributos
        public string Y { get; private set; }
        public PlanoCartesiano(string x, string y)//Método para establecer valor a los atributos
        {
            X = x;
            Y = y;
        }
        public void MostrarDatos()//Método para mostrar los atributos
        {
            Console.WriteLine("X: " + X);
            Console.WriteLine("Y: " + Y);
        }
    }

    internal class circulo
    {
        public int X { get; private set; }//Declaración de los atributos
        public int Y { get; private set; }
        public int Radio { get; private set; }
        public circulo(int x, int y, int radio)
        {
            this.X = x;
            this.Y = y;
            this.Radio = radio;
        }
        public void MostrarDatos()//Método para mostrar los atributos
        {
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
            Console.WriteLine("Radio = " + Radio);
        }
        public void calcularArea()//Método para calcular el área del círculo y mostrarla
        {
            double area = 3.14 * Radio * Radio;
            Console.WriteLine("Area = " + area);
        } 
    }

    internal class Persona1
    {
        public string Nombre { get; private set; }//Declaración de los atributos
        public string Apellido { get; private set; }
        public string Edad { get; private set; }
        public string Genero { get; private set; }

        public Persona1(string nombre, string apellido, string edad, string genero) //Método para establecer valor a los atributos
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Genero = genero;
        }
        public void MostrarDatos()//imprimir los valores de la persona en una sola cadena
        {
            Console.WriteLine("Los datos de la persona son los siguientes:\n" +
                $"Nombre: {Nombre}\n" +
                $"Apellido: {Apellido}\n" +
                $"Edad: {Edad}\n" +
                $"Género: {Genero}");
        }
    }

}
