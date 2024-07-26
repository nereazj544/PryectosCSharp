// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OBJETIVO 6: CONTROL FLUJO DE UN PROGRAMA\n");
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";

        Console.WriteLine("\n#### CONTROL FLUJO DE UN PROGRAMA: \"IF - ELSE - IF ELSE\" ####\n");

        Random r = new Random();
        int num1 = r.Next(1, 100); //genera un numero ente 1 y 100
        int num2 = r.Next(1, 100); //genera un numero ente 1 y 100
        if (num1 > num2)
        {
            Console.WriteLine("El numero 1: " + num1 + " es > que el numero 2: " + num2);
        }
        else
        {
            Console.WriteLine("El numero 1: " + num1 + " no es > que el numero 2: " + num2);
        }

        Console.Write("\n===============\n");
        Console.WriteLine("Escribe un numero del 1 al 10: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Has escrito: {0}", valor);
        Console.WriteLine("\n=== COMPROBANDO NUMERO ===");

        if (valor >= 10)
        {
            Console.Write("¡Tu numero {0} es mayor o igual que 10!\n", valor);
        }
        else
        {
            Console.Write("¡Tu numero {0} no es mayor que 10!\n", valor);
        }

        Console.Write(mensaje);
        Console.ReadLine();

        List<int> list = new List<int> { 2, 13, 8, 9, 14, 7, 29 };
        Console.WriteLine("> Escribe un numero: ");
        valor = Convert.ToInt32(Console.ReadLine());
        if (list.Contains(valor))
        {
            Console.Write("> ¡Tu numero {0} aparece en la lista!", valor);
        }
        else
        {
            Console.Write("> ¡Tu numero {0} no aparece en la lista!", valor);
        }



        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("> Escribe un primer numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("> Tu primer numero es {0}", n1);

        Console.WriteLine("> Escribe un segundo numero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("> Tu segundo numero es {0}", n2);

        if (n1 > n2)
        {
            Console.WriteLine("> ¡Tu primer numero {0} es > que tu segundo numero {1}!\n", n1, n2);

        }
        else
        {
            if (n1 < n2)
            {
                Console.WriteLine("> ¡Tu primer numero {0} es < que tu segundo numero {1}!\n", n1, n2);

            }
            else
            {

                Console.WriteLine("> ¡Tu primer numero {0} es igual que tu segundo numero {1}!\n", n1, n2);
            }
        }

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### CONTROL FLUJO DE UN PROGRAMA: \"SWITHC\" ####\n");

        Console.WriteLine("> CODIGOS PROMOCIONALES: ORO, PLATA, BRONCE O PLATINO");
        Console.WriteLine("> Introduce su codigo promocional para saber su descuento: ");
        string cdg = Console.ReadLine().ToLower();

        switch (cdg)
        {
            case("oro"):
            Console.WriteLine("El descuento aplicado es del 50%");
            break;
            case("plata"):
            Console.WriteLine("El descuento aplicado es del 25%");
            break;
            case("bronce"):
            Console.WriteLine("El descuento aplicado es del 5%");
            break;
            case("platino"):
            Console.WriteLine("El descuento aplicado es del 15%");
            break;
            default:
                Console.WriteLine("> No has introducido un codigo promocional valido");

                break;
        }







    }
}
