namespace BIBLIOTECA_P3.Metodos
{
    class Libros
    {
        string Titulo;
        string ISBN;
        Autores AutorL;
        
        public Libros(string iSBN, string titulo)
        {
            ISBN = iSBN;
            Titulo = titulo;
        }

        public void AñadirAutores(Autores autores)
        {
            AutorL = autores;
        }
        public string GetTitulo()
        {
            return Titulo;
        }
        public void MostrarLibro()
        {
            System.Console.WriteLine("== DATOS DEL LIBRO ==");
            System.Console.WriteLine("> TITULO: \"{0}\"\n > ISBN: \"{1}\"", Titulo, ISBN);
            AutorL.MostrarAutro();
        }

    }
}
