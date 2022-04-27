using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        Random rnd = new Random();
        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            CargarEscuela();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alumno in curso.Alumnos)
                {
                    GenerarEvaluacion(curso, alumno);
                }
            }
        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var Alumnos = from n1 in nombre1
                          from n2 in nombre2
                          from a1 in apellido1
                          select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return Alumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }

        private void GenerarEvaluacion(Curso curso, Alumno alumno, int CantidadEvaluacion = 5)
        {
            foreach (var asignatura in curso.Asignaturas)
            {
                if (asignatura == null) return;

                while (CantidadEvaluacion > 0)
                {
                    Evaluacion evaluacion = new Evaluacion()
                    {
                        Nombre = $"quiz {asignatura.Nombre} {CantidadEvaluacion}",
                        Asignatura = asignatura,
                        Alumno = alumno,
                        Nota = (rnd.NextDouble() * 5)
                    };
                    CantidadEvaluacion--;
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                new Asignatura{Nombre ="Matematicas"},
                new Asignatura{Nombre ="Educación fisica"},
                new Asignatura{Nombre ="Castellano"},
                new Asignatura{Nombre ="Ciencia naturales"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        void CargarEscuela()
        {
            Escuela = new Escuela("Platzi Academy", "Colombia", "Bogota", TiposEscuela.Secundaria);

            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "201",Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "301",Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "102", Jornada=TiposJornada.Tarde},
                new Curso(){Nombre = "202",Jornada=TiposJornada.Tarde},
                new Curso(){Nombre = "302",Jornada=TiposJornada.Tarde}
             };

            foreach (var Curso in Escuela.Cursos)
            {
                int cantidadRand = rnd.Next(5, 20);
                Curso.Alumnos = GenerarAlumnos(cantidadRand);
            }
        }
    }


}