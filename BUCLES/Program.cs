// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("OBJETIVO 7: BUCLES \n");
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";

        Console.WriteLine("\n#### BUCLES: \"WHILE\" ####\n");

        //! While se usa para cuando no se sepa el numero exacto que se quiere iterar

        List<int> v = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 0 };
        int ñ = 0;
        bool r = false;

        while (!r)
        {
            Console.Write(v[ñ] + " ");
            ñ = ñ + 1;
            if (ñ == v.Count)
            {
                r = true;
            }
        }

        Console.Write(mensaje);
        Console.ReadLine();

        int vl;
        bool fin = false;
        while (!fin)
        {
            Console.WriteLine("\nEscribe un numero: ");
            vl = Convert.ToInt32(Console.ReadLine());
            if (vl > 100)
            {
                fin = true;
                Console.WriteLine("Tu numero {0} es mayor que 100", vl);
            }
            else
            {
                if (vl == 100)
                {

                    fin = true;
                    Console.WriteLine("Tu numero {0} igual que 100", vl);
                }
                else
                {
                    Console.WriteLine("Tu numero {0} no es mayor ni igual que 100", vl);

                }
            }

        }
        Console.Write("HA FINALIZADO EL PROGRAMA");

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### BUCLES: \"FOR\" ####\n");

        List<string> listaCadena = new List<string> { "Llévame", "con", "la", "correa", "a", "pasear" };// EMJAY, BB ASUL & L-Gante - I'M A SLUT
        for (int i = 0; i < listaCadena.Count; i++)
        {
            Console.WriteLine(listaCadena[i]);
        }


        Console.WriteLine("\n#### BUCLES: \"DO WHILE\" ####\n");

        int vla = 0;
        do
        {
            Console.WriteLine("\nEscribe un numero (>=10): ");
            vla = Convert.ToInt32(Console.ReadLine());
        } while (vla >= 10);
        Console.Write("HA FINALIZADO EL PROGRAMA");

        Console.WriteLine(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### BUCLES: \"ANIDADOS (NO ANIMADOS)\" ####\n");
        //! IMPRIMIR TODOS LOS NUEMORES PRIMOS 
        for (int numero = 1; numero <= 1000; numero++)
        {
            bool primo = true;
            for (int contador = numero - 1; contador > 1; contador--)
            {
                if (numero % contador == 0)
                {
                    primo = false;
                }
            }
            if (primo)
            {
                System.Console.WriteLine(numero);
                System.Console.WriteLine(Environment.NewLine); //Envia un salto de linea.
            }
        }
        Console.WriteLine("\n#### BUCLES: \"FOREACH\" ####\n");

        foreach (int num in v)
        {
            System.Console.WriteLine("Numero {0}", num);
        }

        Dictionary<string, string> dias = new Dictionary<string, string>();
        dias.Add("Monday", "Lunes");
        dias.Add("Tuesdat", "Martes");
        dias.Add("Wednesday", "Miercoles");
        dias.Add("Thursday", "Jueves");
        dias.Add("Friday", "Viernes");
        dias.Add("Sunday", "Sabado");
        dias.Add("Saturday", "Domingo");
        foreach (KeyValuePair<string, string> key in dias)
        {
            System.Console.WriteLine(" {0} -> {1}", key.Key, key.Value);

        }

    }
}