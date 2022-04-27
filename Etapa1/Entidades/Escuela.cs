using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public override string ToString()
        {
            return $"Info de la escuela:\nNombre: {Nombre}, Tipo: {TipoEscuela} \n" +
            $"Pais: {Pais}, Ciudad: {Ciudad}";
        }

          public Escuela(string nombre, string pais, string ciudad, TiposEscuela tipoEscuela)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.TipoEscuela = tipoEscuela;

        }

        public Escuela(string nombre, int añoDeCreacion) =>
                (Nombre, AñoDeCreacion) = (nombre, añoDeCreacion);


    }
}