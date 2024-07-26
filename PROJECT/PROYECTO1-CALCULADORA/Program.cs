// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROYECTO 1: CALCULADORA \n");
        /* Se utilizara lo siguiente:
        1- Escritura de texto por pantalla
        2- Lectura de informacion introducida por el/los users
        3- Controlar el flujo mediante un switch
        4- Bucle While
        5- Operador logico NOT (!)
        6- Operadores matematicos.

        Este proyecto consiste en desarrollar el funcionamiento basico de una calculadora.
        */
        System.Console.WriteLine(Environment.NewLine);
        //Salto de linea que lo que hace es que detecte el salto de linea equivalente al \n pero para todos los S.O.
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


        int respuesta = Convert.ToInt32(Console.ReadLine());
        bool SALIR = false; //!No tiene sentido esta variable pero vale

        //NUMEROS 
        int n1;
        int n2;
        int r;
        //LOGICA DE LA CALCULADORA
        while (!SALIR)
        {
            switch (respuesta)
            {
                case (1): //SUMAR
                    System.Console.WriteLine("> El sistema necesita el primer numero para:  \"sumar\" ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("> El sistema necesita el segundo numero para: \"sumar\" ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    r = n1 + n2;
                    System.Console.WriteLine("> El sistema ha resulto la \"sumar\" : " + r);
                    // Environment.Exit(0); // Termina la aplicación con código de salida 0

                    break;
                case (2): //RESTAR
                    System.Console.WriteLine("> El sistema necesita el primer numero para:  \"restar\" ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("> El sistema necesita el segundo numero para: \"restar\" ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    r = n1 - n2;
                    System.Console.WriteLine("> El sistema ha resulto la \"resta\" : " + r);
                    break;
                case (3): //MULTIPLICAR
                    System.Console.WriteLine("> El sistema necesita el primer numero para:  \"multiplicar\" ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("> El sistema necesita el segundo numero para: \"multiplicar\" ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    r = n1 * n2;
                    System.Console.WriteLine("> El sistema ha resulto la \"multiplicacion\" : " + r);

                    break;
                case (4): //DIVIDIR
                    System.Console.WriteLine("> El sistema necesita el primer numero para:  \"dividir\" ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("> El sistema necesita el segundo numero para: \"dividir\" ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    r = n1 / n2;
                    System.Console.WriteLine("> El sistema ha resulto la \"division\" : " + r);

                    break;

                case (5): //SALIR   
                    SALIR = true;
                    break;
            }

        }
        System.Console.WriteLine("> El sistema ha detectado que deseas salir.");
        System.Console.WriteLine("> El sistema ha finalizado el programa.");
        Environment.Exit(0); // Termina la aplicación con código de salida 0





    }
}