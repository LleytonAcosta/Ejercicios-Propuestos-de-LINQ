using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
                new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };


            //1. Muestre por pantalla los nombres de los estudiantes
            Console.WriteLine("------------------Mostrar por pantalla los nombres de los estudiantes------------------");
            List<string> imprimir = (from Nom in details
                                     orderby Nom.Nombre ascending
                                     select (Nom.Nombre)).ToList();
            Console.WriteLine(string.Join("\n",imprimir));
            Console.WriteLine("");



            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("------------------Mostrar por pantalla los nombres y apellidos ordenados por promedio de mayor a menor------------------");
            var NomApell = details.OrderByDescending(Promed => Promed.Promedio).Select(NombreApellido => new { NombreApellido.Nombre, NombreApellido.Apellido });
            Console.WriteLine(string.Join("\n", NomApell));
            Console.WriteLine("");


            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("------------------Mostrar por pantalla los apellidos de los estudiantes en orden ascendente alfabéticamente ------------------");
            List<string> Ascapellido = (from date in details
                                        orderby date.Apellido ascending
                                        select (date.Apellido)).ToList();
            Console.WriteLine(string.Join("\n",Ascapellido));
            Console.WriteLine("");

            //4. Muestre por pantalla los datos del estudiante mas joven
            Console.WriteLine("------------------Mostrar por pantalla los datos del estudiante mas joven------------------");
            var EstudianteMasJoven = details.Min(E => E.Edad + "  " + E.Nombre + " " + E.Apellido + " " + E.Promedio);
            Console.WriteLine(EstudianteMasJoven);
            Console.WriteLine("");



            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:

            //1. Muestre por pantalla el cuadrado de los números
            Console.WriteLine("------------------Mostrar por pantalla el cuadrado de los numeros de la lista------------------");
            var Cuadrado = list.Select(num => num * num);
            Console.WriteLine(string.Join(" ", Cuadrado));
            Console.WriteLine("");

            //2. Muestre por pantalla los números pares
            Console.WriteLine("------------------Mostrar por pantalla los numeros pares------------------");
            List<int> Pares = list.FindAll(numero => numero % 2 == 0);
            Console.WriteLine(string.Join(" ",Pares));
            Console.WriteLine("");

            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Console.WriteLine("------------------Mostrar por pantalla el resutlado de multiplicar por 5 los números impares------------------");
            List<int> Impar = list.FindAll(i => i % 2 != 0);
            var multi = Impar.Select(j => j * 5);
            Console.WriteLine(string.Join(" ", multi));
        }
    }
}
    
