using static System.Console;

namespace CoreEscuela.util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadLeft(tam,'=');
            WriteLine(linea);
        }

        public static void WriteTitle(string Titulo)
        {
            int tamaño = Titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {Titulo} |");
            DibujarLinea(tamaño);

        }
    }
}