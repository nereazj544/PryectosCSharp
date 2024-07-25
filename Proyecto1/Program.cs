// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("OBJETIVO 1: VARIABLE Y COSTANTES \n");
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";
        //Manejo de mensajes por pantalla: usando variables

        Console.WriteLine("MENSAJE POR CONSOLA USANDO VARIABLES: \n");

        string nombre = "Neo"; //Variable - texto
        int edad = 19; //Variable - numero
        Console.WriteLine("CONCATENADO: Hola, mi nombre es: " + nombre + ".\n Actualmente tengo " + edad + " años"); //Concatenando variables
        Console.WriteLine("SystemOutFormateado: Hola, mi nombre es {0}. Actualmente tengo {1} años", nombre, edad); //como si fuera un array(raro)
        Console.WriteLine("SystemOutFormateado: Hola, mi nombre es \"{0}\" ", nombre); //como si fuera un array(raro) + añadir comillas

        // Leer informacion desde teclado y mostrarla
        Console.WriteLine("OBJETIVO 2: MANEJO DE MENSAJES POR PANTALLA \n");
        Console.WriteLine("\nMENSAJE POR CONSOLA USANDO TECLADO PARA INTRODUCIR DATOS: \n");
        
        Console.WriteLine("\n ¿Cual es tu nombre?");
        string user = Console.ReadLine(); //Es como Scanner de Java, Line es para String 
        Console.Write("Hola " + user + ", ahora dime, ¿que edad tienes? ");
        // int edaduser = Console.ReadLine();
        string edaduser = Console.ReadLine();
        Console.Write("Asi que te llamsa {0} y tienes {1}", user, edaduser);
        // Console.WriteLine("CONCATENADO: Hola, mi nombre es: " + user + ".\n Actualmente tengo " + edaduser + " años"); //Concatenando variables

        Console.Write(mensaje);
        Console.ReadLine();


        //Tipos de datos básicos y operadores
        Console.WriteLine("\nTipos de datos básicos y operadores: \n");

        Console.WriteLine("#### SUMA, MULTIPLICACION, RESTA Y DIVISON ENTERA ####");
        Console.Write("Primer numero (entero): ");
        int num1 = Convert.ToInt32(System.Console.ReadLine()); //Lo que hace esto es transformar los valores leidos a numeros enteros
        Console.Write("Primer numero añado es: " + num1 + ", enter para continuar");
        Console.ReadLine();
        Console.Write("Segundo numero (entero): ");
        int num2 = Convert.ToInt32(System.Console.ReadLine());
        Console.Write("\nSegundo numero añado es: " + num2 + "\n");
        int rsuma = num1 + num2;
        int rresta = num1 - num2;
        int rmul = num1 * num2;
        int rdi = num1 / num2;
        Console.Write("\n#### RESULTADOS DE LAS OPERACIONES (ENTERO) #### \n");
        Console.Write("\nEl resultado de la suma es: \"{0}\"", rsuma);
        Console.Write("\nEl resultado de la resta es: \"{0}\"", rresta);
        Console.Write("\nEl resultado de la multiplicacion es: \"{0}\"", rmul);
        Console.Write("\nEl resultado de la division es: \"{0}\"", rdi);

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("#### SUMA, MULTIPLICACION, RESTA Y DIVISON DECIMALES ####");

        Console.Write("Primer numero (real): ");
        decimal numreal1 = Convert.ToDecimal(System.Console.ReadLine()); //Lo que hace esto es transformar los valores leidos a numeros decimales
        Console.Write("Primer numero añado es: " + numreal1 + ", enter para continuar\n");
        Console.ReadLine();
        Console.Write("Segundo numero (real): ");
        decimal numreal2 = Convert.ToDecimal(System.Console.ReadLine());
        Console.Write("Segundo numero añado es: " + numreal2 + ", enter para continuar\n");
        decimal rrals = numreal1 + numreal2;
        decimal rralr = numreal1 - numreal2;
        decimal rralmul = numreal1 + numreal2;
        decimal rraldi = numreal1 / numreal2;
        Console.Write("\n#### RESULTADOS DE LAS OPERACIONES (DECIMALES) #### \n");
        Console.Write("\nEl resultado de la suma es: \"{0}\"", rrals);
        Console.Write("\nEl resultado de la resta es: \"{0}\"", rralr);
        Console.Write("\nEl resultado de la multiplicacion es: \"{0}\"", rralmul);
        Console.Write("\nEl resultado de la division es: \"{0}\"", rraldi);


        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("#### MODULO ####");
        Console.Write("Primer numero (real): ");
        int nummodulo1 = Convert.ToInt32(System.Console.ReadLine());
        Console.Write("Primer numero añado es: " + nummodulo1 + ", enter para continuar\n");
        Console.ReadLine();
        Console.Write("Segundo numero (real): ");
        int nummodulo2 = Convert.ToInt32(System.Console.ReadLine());
        Console.Write("Segundo numero añado es: " + nummodulo2 + ", enter para continuar\n");
        int rmodulo = nummodulo1 % nummodulo2;
        Console.Write("\n La operacione es la siguiente: " + nummodulo1 + " % " + nummodulo2 + ".\n El resultado es: " + rmodulo);
    }
}