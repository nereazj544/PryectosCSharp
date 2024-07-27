namespace BIBLIOTECA_P3.Metodos
{
    class Biblioteca
    {
        List<Libros> ListaLibros;

        public Biblioteca()
        {
            ListaLibros = new List<Libros>();
        }

        public void AñadirLibros(Libros libros)
        {
            ListaLibros.Add(libros);
        }
        public void BorrarLibro(string titulo)
        {
            bool encontrar = false;
            int p = -1;
            foreach (Libros libros in ListaLibros)
            {
                p++;
                if (libros.GetTitulo() == titulo)
                {
                    encontrar = true;
                    break;
                }

            }
            if (encontrar)
            {
                ListaLibros.RemoveAt(p);
                System.Console.WriteLine("Libro borrado");
            }
            else
            {
                System.Console.WriteLine("Libro no encontrado");
            }
        }
        public void MostrarBiblioteca()
        {
            System.Console.WriteLine("== DATOS DENTRO DE BIBLIOTECA ==");
            foreach (Libros libros in ListaLibros)
                libros.MostrarLibro();

            {

            }
        }

    }
}
