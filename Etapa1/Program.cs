using System;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.util;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            EscuelaEngine engine = new();
            engine.Inicializar();
            ImprimirCursosEscuela(engine.Escuela);
        }

        static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos == null) return;

            Printer.WriteTitle("Cursos de la escuela");

            foreach (var curso in escuela.Cursos)
            {
                Console.WriteLine($"Nombre: {curso.Nombre}. El ID es: {curso.Id}");
            }
        }
    }
}
