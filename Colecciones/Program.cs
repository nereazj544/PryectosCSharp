// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OBJETIVO 5: COLECCIONES \n");
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";

        Console.WriteLine("\n#### COLECCIONES: \"ARRYS\" ####\n");
        string s = "Llévame con la correa a pasear"; // EMJAY, BB ASUL & L-Gante - I'M A SLUT
        /*
        ! Los Arrays siempre empiezan por 0
        Llévame = 0
        con = 1
        la = 2
        correa = 3 
        a = 4
        pasear = 5
        */
        string[] arrayStr = s.Split(' ');
        Console.WriteLine("> ORIGINAL: " + s);
        Console.Write("> CADENA SEGMENTADA: \n");
        Console.WriteLine(arrayStr[0]);
        Console.WriteLine(arrayStr[1]);
        Console.WriteLine(arrayStr[2]);
        Console.WriteLine(arrayStr[3]);
        Console.WriteLine(arrayStr[4]);
        Console.WriteLine(arrayStr[5]);
        Console.WriteLine("==================================================================================");

        string cdnSeparadores = "Perro,Gato.Pajaro,Tigre.Leon";

        char[] separadores = { ',', '.' };
        arrayStr = cdnSeparadores.Split(separadores);
        Console.WriteLine("> ORIGINAL: " + cdnSeparadores);
        Console.Write("> CADENA CON SEPARADORES: \n");
        Console.WriteLine(arrayStr[0]);
        Console.WriteLine(arrayStr[1]);
        Console.WriteLine(arrayStr[2]);
        Console.WriteLine(arrayStr[3]);
        Console.WriteLine(arrayStr[4]);


        int[] numeros = { 10, 2, 13, 5, 4 };
        Console.WriteLine("> Cadena Original: " + numeros[0] + ", " + numeros[1] + ", " + numeros[2] + ", " + numeros[3]);

        numeros[0] = 50;
        numeros[1] = numeros[3] - 2;

        Console.WriteLine("> Número de elementos " + numeros.Length);
        Console.WriteLine(numeros[0] + ", " + numeros[1] + ", " + numeros[2] + ", " + numeros[3]);

        Array.Sort(numeros);
        Console.WriteLine("> Ordenados: " + numeros[0] + ", " + numeros[1] + ", " + numeros[2] + ", " + numeros[3]);

        Array.Reverse(numeros);
        Console.WriteLine("> Al reves: " + numeros[0] + ", " + numeros[1] + ", " + numeros[2] + ", " + numeros[3]);

        //IndexOf = si encuentra el indice dentro del array va a mostar ese indice, si no lo encuentra muesta -1
        Console.WriteLine("> ¿Existe el elemento 4? = " + Array.IndexOf(numeros, 4));
        Console.WriteLine("> ¿Existe el elemento 90? = " + Array.IndexOf(numeros, 90));
        Console.WriteLine("==================================================================================");

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### COLECCIONES: \"LISTAS\" ####\n");
        List<int> listaEnteros = new List<int> { 13, 4, 2, 29 };
        Console.WriteLine(listaEnteros[0]);
        Console.WriteLine(listaEnteros[1]);
        Console.WriteLine(listaEnteros[2]);
        Console.WriteLine(listaEnteros[3]);
        Console.WriteLine("==================================================================================");
        List<string> listaCadena = new List<string> { "Llévame", "con", "la", "correa", "a", "pasear" };// EMJAY, BB ASUL & L-Gante - I'M A SLUT
        Console.WriteLine(listaCadena[0]);
        Console.WriteLine(listaCadena[1]);
        Console.WriteLine(listaCadena[2]);
        Console.WriteLine(listaCadena[3]);
        Console.WriteLine(listaCadena[4]);
        Console.WriteLine(listaCadena[5]);
        Console.WriteLine("==================================================================================");

        List<int> Enteros = new List<int> { 13, 4, 2, 29 };
        Console.WriteLine("Tamaño de la lista: " + Enteros.Count);
        Console.WriteLine("Lista: " + Enteros[0] + ", " + Enteros[1] + ", "+ Enteros[2] + ", "+ Enteros[3]);

        //Añadir numeros
        Enteros.Add(30);
        Enteros.Add(10);
        Console.WriteLine("Tamaño de la lista: " + Enteros.Count);
        Console.WriteLine("Lista: " + Enteros[0] + ", " + Enteros[1] + ", "+ Enteros[2] + ", "+ Enteros[3] + Enteros[4] + ", " + Enteros[5]);

        Enteros.Insert(0, 0);
        Enteros.Insert(3, 999);
        Console.WriteLine("Tamaño de la lista: " + Enteros.Count);
        Console.WriteLine("Lista: " + Enteros[0] + ", " + Enteros[1] + ", "+ Enteros[2] + ", "+ Enteros[3] + Enteros[4] + ", " + Enteros[5] + ", "  + Enteros[6] + ", " + Enteros[7]);



        Console.WriteLine();




        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("\n#### COLECCIONES: \"DICIONARIO\" ####\n");







    }
}
