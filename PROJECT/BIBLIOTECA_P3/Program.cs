// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization.Formatters.Binary;
using BIBLIOTECA_P3.Metodos;

class Program
{
    /* 
        TODO: LISTA DE COSAS QUE HACER EN LA BIBLIOTECA
        Se utilizara lo siguiente:
        1. Mostrar informacion por pantalla.
        2. Lectura de informacion por teclado.
        3. Utilizar datos basicos: numeros, cadenas de texto y listas.
        4. Bucle While.
        5. Bucle ForEach.
        6. Creacion y utilizacion de metodos (funciones).
        7. programacion orientada a objetos.
        8. composicion de clases.

        TODO: LA PARTE DE LAS CLASES
        1. Autor: Contendra la informacion sobre la persona que a escrito el libro.
        2. Libro: contendra la informacion sobre el libro.
        3. Biblioteca clase que contendra todos los libros que componen la biblioteca.
        
        TODO: DETALLES DE LAS CLASES
    1. CLASE AUTOR:
        - Compuesta por:
            - Nombre
            - Apellidos
        - Metodos:
            - Mostrar por pantalla los atributos antes mencionados
    2. CLASE LIBRO:
        - Compueta por:
            - Titulo
            - ISBN
            - AUTOR
        - Metodos:
            - AñadirAutor: almacena la informacion en el atributo Autor
            - Mostrar: mostrar info de libro
            - ObtenerTitulo: devolvera el titulo del libro
    3. Biblioteca: 
        - Atributos:
            - ListaLibros
        - Metodos:
            - NumeroLibros: numero de la lista de los libros
            - AñadirLibro
            - BorrarLibro
            - Mostar


        Este proyecto consiste en desarrollar el funcionamiento basico de una calculadora usando metodos.
        */
    static void Main(string[] args)
    {
        Console.WriteLine("PROYECTO 3: BIBLIOTECA\n");
        System.Console.WriteLine(Environment.NewLine);
        System.Console.WriteLine("** Menú **");
        System.Console.WriteLine("1- Añadir libro a la biblioteca");
        System.Console.WriteLine("2- Mostrar libro");
        System.Console.WriteLine("3- Borrar Libro");
        System.Console.WriteLine("4- ¿Numero de libros?");
        System.Console.WriteLine("5- Salir");
        Opcion();
    }

    private static void Opcion()
    {
        Biblioteca b = new Biblioteca();
        System.Console.WriteLine("> El sistema necesita una opcion: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());
        bool exit = false;
        while (!exit)
        {
            switch (respuesta)
            {
                case (1):
                    //Añadir Libro
                    Añadir(b);
                    break;

                case (2):
                    //Mostrar Lirbo
                    System.Console.WriteLine("> El sistema pasara a mostrar los libros actuales: ");
                    b.MostrarBiblioteca();
                    break;

                case (3):
                    //Borrar Lirbo
                    Borrar();
                    break;

                case (4):
                    //¿Numero lista?
                    Lista();
                    break;

                case (5):
                    exit = true;
                    break;
            }
        }
        System.Console.WriteLine("> El sistema ha detectado que deseas salir.");
        System.Console.WriteLine("> El sistema ha finalizado el programa.");
        Environment.Exit(0); // Termina la aplicación con código de salida 0


    }

 

    private static void Borrar()
    {
        Biblioteca b = new Biblioteca();
        System.Console.WriteLine("> El sistema necesina que inserte: ");
        System.Console.WriteLine("> Titulo a borrar: ");
        b.BorrarLibro(Console.ReadLine());

    }

    private static void Lista()
    {
        System.Console.WriteLine("> El sistema pasara a mostrar la lista de libros actuales: ");
        Biblioteca b = new Biblioteca();
        System.Console.WriteLine(b.Lista());
    }

    static Biblioteca Añadir(Biblioteca b)
    {
        string titulo, isbn, autorn, autora;
        System.Console.WriteLine("> El sistema necesina que inserte: ");
        System.Console.WriteLine("Introduce el titulo del libro: ");
        titulo = Console.ReadLine();
        System.Console.WriteLine("> El sistema necesina que inserte: ");
        System.Console.WriteLine("Introduce el ISBN del libro: ");
        isbn = Console.ReadLine();
        System.Console.WriteLine("> El sistema necesina que inserte: ");
        System.Console.WriteLine("Introduce el nombre del autor del libro: ");
        autorn = Console.ReadLine();
        System.Console.WriteLine("> El sistema necesina que inserte: ");
        System.Console.WriteLine("Introduce el(os) apellido(s) del autor del libro: ");
        autora = Console.ReadLine();

        Autores autores = new Autores(autorn, autora);
        Libros libros = new Libros(isbn, titulo);
        libros.AñadirAutores(autores);
        b.AñadirLibros(libros);
        return b;
    }
}
