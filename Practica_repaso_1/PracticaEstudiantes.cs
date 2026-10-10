using System;
using System.Collections.Generic;

namespace PracticaEstudiantes
{
    // Ejercicio 1: Libro
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Páginas: {Paginas}");
        }
    }

    // Clase base para Ejercicio 2
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    // Ejercicio 2: Estudiante hereda de Persona
    public class Estudiante : Persona
    {
        public string Grado { get; set; }

        public void MostrarInformacionEstudiante()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Grado: {Grado}");
        }
    }

    // Ejercicio 3: Polimorfismo y Encapsulamiento
    public class InstrumentoMusical
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public virtual void Tocar()
        {
            Console.WriteLine("El instrumento está siendo tocado.");
        }
    }

    public class Guitarra : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("La guitarra está sonando.");
        }
    }

    public class Piano : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("El piano está sonando.");
        }
    }

    class Program
    {
        static void Main()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Menú de Práctica ===");
                Console.WriteLine("1. Ejercicio 1 - Clases y Objetos (Libro)");
                Console.WriteLine("2. Ejercicio 2 - Herencia (Estudiante)");
                Console.WriteLine("3. Ejercicio 3 - Polimorfismo y Encapsulamiento (Instrumentos)");
                Console.WriteLine("4. Ejecutar ejemplos de los 3 ejercicios");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        EjecutarEjercicio1();
                        break;
                    case "2":
                        EjecutarEjercicio2();
                        break;
                    case "3":
                        EjecutarEjercicio3();
                        break;
                    case "4":
                        EjecutarEjercicio1();
                        Console.WriteLine();
                        EjecutarEjercicio2();
                        Console.WriteLine();
                        EjecutarEjercicio3();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void EjecutarEjercicio1()
        {
            Console.WriteLine("Ejercicio 1: Clases y Objetos (Libro)");
            Libro libro1 = new Libro
            {
                Titulo = "Cien Años de Soledad",
                Autor = "Gabriel García Márquez",
                Paginas = 417
            };
            libro1.MostrarInformacion();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void EjecutarEjercicio2()
        {
            Console.WriteLine("Ejercicio 2: Herencia (Estudiante)");
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Carlos",
                Edad = 20,
                Grado = "Ingeniería"
            };
            estudiante1.MostrarInformacionEstudiante();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void EjecutarEjercicio3()
        {
            Console.WriteLine("Ejercicio 3: Polimorfismo y Encapsulamiento (Instrumentos)");
            List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>
            {
                new Guitarra { Nombre = "Guitarra acústica" },
                new Piano { Nombre = "Piano de cola" }
            };

            foreach (var instrumento in instrumentos)
            {
                Console.WriteLine($"Instrumento: {instrumento.Nombre}");
                instrumento.Tocar();
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
