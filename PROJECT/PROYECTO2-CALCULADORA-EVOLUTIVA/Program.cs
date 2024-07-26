// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

class Program
{
    static int Calculadora()
    {
        System.Console.WriteLine("Inserte un numero de las opciones dadas en el menu: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());
        bool SALIR = false;
        while (!SALIR)
        {
            switch (respuesta)
            {
                case (1): //Sumar
                    Sumar();
                    break;
                case (2): //Restar
                    Restar();
                    break;
                case (3): //Multiplicar
                    Multiplicar();
                    break;
                case (4): //Dividir
                    Dividir();
                    break;

                case (5): //SALIR   
                    SALIR = true;
                    break;
            }
        }
        System.Console.WriteLine("> El sistema ha detectado que deseas salir.");
        System.Console.WriteLine("> El sistema ha finalizado el programa.");
        Environment.Exit(0); // Termina la aplicación con código de salida 0
        return respuesta;
    }

    static int PedirNumero()
    {
        System.Console.WriteLine("Introduce un numero");
        int Num = Convert.ToInt32(Console.ReadLine());
        return Num;
    }
    private static void Dividir()
    {
        System.Console.WriteLine("== DIVIDIR ==");
        int v1 = PedirNumero();
        int v2 = PedirNumero();
        int r = v1 / v2;
        System.Console.WriteLine("Resultado de la \"dividir\": " + r);
        throw new NotImplementedException();
    }

    private static void Multiplicar()
    {
        System.Console.WriteLine("== MULTIPLICAR ==");
        int v1 = PedirNumero();
        int v2 = PedirNumero();
        int r = v1 * v2;
        System.Console.WriteLine("Resultado de la \"multiplicacion\": " + r);

    }
    private static void Restar()
    {

        System.Console.WriteLine("== RESTAR ==");
        int v1 = PedirNumero();
        int v2 = PedirNumero();
        int r = v1 - v2;
        System.Console.WriteLine("Resultado de la \"resta\": " + r);
    }

    private static void Sumar()
    {
        System.Console.WriteLine("== SUMA ==");
        int v1 = PedirNumero();
        int v2 = PedirNumero();
        int r = v1 + v2;
        System.Console.WriteLine("Resultado de la \"suma\": " + r);

    }

    static void Main(string[] args)
    {
        Console.WriteLine("PROYECTO 2: CALCULADORA EVOLUTIVA\n");
        /* 
        TODO: LISTA DE COSAS QUE HACER EN LA CALCULADORA
        Se utilizara lo siguiente:
        1- Escritura de texto por pantalla
        2- Lectura de informacion introducida por el/los users
        3- Controlar el flujo mediante un switch
        4- Bucle While
        5- Operador logico NOT (!)
        6- Operadores matematicos.

        TODO: LA PARTE EVOLUCIONATIVA (v2) DEL PROYECTO ES LO SIGUIENTE
        1- AÑADIR METODO DE SUMAR: Se encarga de sumar
        2- AÑADIR METODO DE RESTAR: Se encarga de restar
        3- AÑADIR METODO DE MULTIPLICAR: Se encarga de multiplicar
        4- AÑADIR METODO DE Dividir: Se encarga de divir
        5- AÑADIR METODO DE Calculadora: Se encarga de socilitar la opcion y ejecutar el bucle

        Este proyecto consiste en desarrollar el funcionamiento basico de una calculadora usando metodos.
        */

        System.Console.WriteLine("***** CALCULADORA *****");
        System.Console.WriteLine(Environment.NewLine);
        System.Console.WriteLine(" ******** ");
        System.Console.WriteLine(" MENÚ ");
        System.Console.WriteLine(" ******** ");
        System.Console.WriteLine("1) Sumar");
        System.Console.WriteLine("2) Restar");
        System.Console.WriteLine("3) Multiplicar");
        System.Console.WriteLine("4) Divison");
        System.Console.WriteLine("5) SALIR");

        Calculadora();

    }
}