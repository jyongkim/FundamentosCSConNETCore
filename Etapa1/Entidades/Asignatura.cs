using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public String Id { get; set; }
        public string Nombre { get; set; }

        public Alumno()
        {
            Id  = Guid.NewGuid().ToString();
        }

    }
}