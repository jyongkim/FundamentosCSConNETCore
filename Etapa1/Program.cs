using System;
using CoreEscuela.Entidades;

namespace Etapa2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
            ciudad: "Bogotá", pais: "Colombia");
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso() { Nombre = "101" };

            var curso2 = new Curso()
            {
                Nombre = "201",

            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso
            {
                Nombre = "301",

            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("=============================");
            ImprimirCursos(arregloCursos);

        }
        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, ID: {arregloCursos[contador].UniqueID}");
                contador++;
            }
        }
    }
}
