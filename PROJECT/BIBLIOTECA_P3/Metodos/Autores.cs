namespace BIBLIOTECA_P3.Metodos
{
    class Autores
    {
        string Nombre;
        string Apellidos;

        public Autores(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }
        public void MostrarAutro()
        {
            System.Console.WriteLine("== DATOS DEL AUTOR ==");
            System.Console.WriteLine("> NOMBRE: \"{0}\"\n > APELLIDOS: \"{1}\"", Nombre, Apellidos);
        }
    }
}
