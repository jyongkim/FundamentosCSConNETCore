using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public String Id { get; set; }
        public string Nombre { get; set; }
        
        public Asignatura()
        {
            Id  = Guid.NewGuid().ToString();
        }

    }
}