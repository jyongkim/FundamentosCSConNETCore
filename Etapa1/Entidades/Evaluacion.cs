using System;

namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public String Id { get; set; }
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public Double Nota { get; set; }
        
        public Evaluacion()
        {
            Id  = Guid.NewGuid().ToString();
        }

    }
}