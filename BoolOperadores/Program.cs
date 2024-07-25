// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";

        // OPERADORES LOGICOS
        Console.WriteLine("\n#### OPERADORES LOGICOS: \"BOOLEANOS\" ####\n");
        bool v1 = true;
        bool v2 = false;
        Console.Write("Valor 1: " + v1 + "\n");
        Console.Write("Valor 2: " + v2);


        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### OPERADORES LOGICOS: \"AND\" ####\n");
        Console.WriteLine("El operador AND se representa con \"&&\" \n");

        bool VT = true;
        bool VF = false;

        Console.WriteLine("TRUE AND TRUE = " + (VT && VT));
        Console.WriteLine("TRUE AND FALSE = " + (VT && VF));
        Console.WriteLine("FALSE AND FALSE = " + (VF && VF));

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### OPERADORES LOGICOS: \"OR\" ####\n");
        Console.WriteLine("El operador OR se representa con \"||\" \n");
        Console.WriteLine("TRUE AND TRUE = " + (VT || VT));
        Console.WriteLine("TRUE AND FALSE = " + (VT || VF));
        Console.WriteLine("FALSE AND FALSE = " + (VF || VF));

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### OPERADORES LOGICOS: \"NOT\" ####\n");
        Console.WriteLine("El operador NOT se representa con \"!\" \n");
        Console.WriteLine("NOT TRUE = " + (!VT));
        Console.WriteLine("NOT FALSE= " + (!VF));
        
        Console.Write(mensaje);
        Console.ReadLine();
   
        Console.WriteLine("\n#### OPERADORES LOGICOS: \"RELACIONELAES\" ####\n");
        Console.Write("Numero 1 (entero): ");
        int num1 = Convert.ToInt32(System.Console.ReadLine());
        
        Console.Write("> Se ha establecido el numero: " + num1 + ". Al valor Numero 1");
        Console.Write(mensaje);
        Console.ReadLine();

        Console.Write("Numero 2 (entero): ");
        int num2 = Convert.ToInt32(System.Console.ReadLine());
        Console.Write("> Se ha establecido el numero: " + num2 + ". Al valor Numero 2");
        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("> Mayor... : "+ num1 + ">" + num2 + ":" + (num1>num2)); //Mayor
        Console.WriteLine("> Mayor o igual... : "+ num1 + ">=" + num2 + ":" + (num1>=num2)); //Mayor o igual
        Console.WriteLine("> Menor... : "+ num1 + "<" + num2 + ":" + (num1<num2)); //Menor
        Console.WriteLine("> Menor o igual... : "+ num1 + "<=" + num2 + ":" + (num1<=num2)); //Menor o igual
        Console.WriteLine("> Igual... : "+ num1 + "==" + num2 + ":" + (num1==num2)); // igual que
        Console.WriteLine("> Distinto... : "+ num1 + "!=" + num2 + ":" + (num1!=num2)); //ditinto
































    }
}
