// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{


    static void Saludar()
    {
        Console.WriteLine("OBJETIVO 8: FUNCIONES (METODOS)\n");
        System.Console.WriteLine("Esto es una \"Funcion\" lo que se conoce en java como \"Metodos (funciones o procedimeintos)\"");
    }
    static void Saludar2()
    {
        Console.WriteLine("OBJETIVO 8: FUNCIONES ANIDADOS (METODOS)\n");
        System.Console.WriteLine("Esto es una \"Funcion\" lo que se conoce en java como \"Metodos (funciones o procedimeintos)\"");
    }
    static void Mayor(int valor)
    {
        if (valor > 0)
        {
            System.Console.WriteLine("El valor \"{0}\" es mayor que 0", valor);
        }
        else
        {
            if (valor == 0)
            {
                System.Console.WriteLine("El valor \"{0}\" es igual que 0", valor);

            }
            else
            {

                System.Console.WriteLine("El valor \"{0}\" no es mayor que 0", valor);
            }
        }
    }
    static int SolicitarNum()
    {
        System.Console.WriteLine("Inseterte un numero");
        int vl = Convert.ToInt32(Console.ReadLine());
        return vl;
    }
    static void Sumar()
    {
        int v1 = SolicitarNum();
        int v2 = SolicitarNum();
        int r = v1+ v2;
        System.Console.WriteLine("RESULTADO: " + r);
    }
    static void Main(string[] args)
    {
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";
        Saludar();

        System.Console.WriteLine("Inserte un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Mayor(num);
        System.Console.WriteLine(Environment.NewLine);
        System.Console.WriteLine(mensaje);
        Console.ReadLine();

        Saludar2();
        Sumar();

    }


}