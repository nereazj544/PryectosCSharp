// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OBJETIVO 4: CADENAS DE TEXTO \n");
        string mensaje = "\n #### ENTER PARA CONTINUAR #### \n";


        Console.WriteLine("### METODOS PROPIOS DE LAS CADENAS: MAYUSCULAS Y MINUSCULAS ###");


        string c = " a Jude Sharp le gusta el lenguaje C Sharp";

        Console.WriteLine("> ORIGINAL: " + c);
        Console.WriteLine("> Longitud: " + c.Length);
        c = c.ToUpper();
        Console.WriteLine("> MAYUSCULAS: " + c);
        Console.WriteLine("> minusculas: " + c.ToLower());

        //! ToUpper = convierte todos los caracteres a Mayusculas
        //! ToLower = convierte todos los caracteres a Minusculas

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("### METODOS PROPIOS DE LAS CADENAS: CONCATENAR Y FORMATO ###");

        string CamGirl = "pago mis billes sin salir del cuarto"; // Villano Antillano - CamGirl
        string PeonReina = "Fuiste el peón, pero yo soy la reina"; // Lorena Gómez - El Peón Y La Reina
        string ElMomento = "Era el momento de empezar a latir"; // LA CASA AZUL - El Momento
        string Judas = "Dime qué haces pa' enloquecerme así"; // Bad Gyal, KHEA - Judas
        string TrucoOTraro = "Mi sangre corre por un manantial que viene y va"; // MEGARA - Truco O Trato
        string s = "Llévame con la correa a pasear"; // EMJAY, BB ASUL & L-Gante - I'M A SLUT

        string cadenaConcatenar1 = string.Concat(Judas, "\n", CamGirl, "\n", PeonReina, "\n", ElMomento, "\n", TrucoOTraro, "\n", s);
        string cadenaConcatenar2 = string.Concat(Judas + "\n" + CamGirl + "\n" + PeonReina + "\n" + ElMomento + "\n" + TrucoOTraro + "\n", s);

        Console.WriteLine("### METODO: CONCATENAR ###");
        Console.WriteLine("\n> En este ejemplo se usa el metodo de \"string.Concat\": \n" + cadenaConcatenar1);
        Console.WriteLine("==================================================================================");
        Console.WriteLine("\n> En este ejemplo se usa el metodo de \"llamar a la variable y despues añadilre + \":\n " + cadenaConcatenar2);
        Console.WriteLine("==================================================================================");

        Console.WriteLine("### METODO: FORMATO ###");

        Console.WriteLine(">En este ejemplo es directamnete usando el formato al mostrar los datos: \n" +
        "Villano Antillano - CamGirl : {0} \n" +
        "Lorena Gómez - El Peón Y La Reina : {1}\n" +
        "LA CASA AZUL - El Momento {2} \n" +
        "Bad Gyal, KHEA - Judas : {3} \n" +
        "MEGARA - Truco O Trato : {4} \n" +
        "EMJAY, BB ASUL & L-Gante - I'M A SLUT : {5}",
        CamGirl, PeonReina, ElMomento, Judas, TrucoOTraro, s);
        string cd = "> Si pregunta: \"¿Estás soltera?\", les voy a responder: {0}\n. > Si pregunta: \"¿Estás soltera?\", les voy a responder: {1}\n ";
        string cadenaFormato1 = string.Format(cd, "Yo tengo un novio, yo tengo un novio. \nYo tengo un novio que me come to los dias\n", "Tengo un novio pa cada día de la semana.\n Uno que la tiene chica, otro la tiene mediana.\n Un moreno que se vino de La Habana.\n Uno que lleva peluca, le digo: \"Hannah Montana\".\n El lunes un chulo, el martes un guarro, el miércoles un pesao, le digo: \"No me coma el tarro\". \nJueves el bombero, me hace un puchero.\nEl del viernes agricultor y lo hacemos en el tractor. \nSábado y domingo, es cuando más chingo. \nUn latino en la noche y por la mañana un gringo. \nLa tiene doblá, como el cuello de un flamingo.\n Escuchan los vecinos, si me voy, yo grito: \"¡Bingo!\". ");

        Console.WriteLine("==================================================================================");

        Console.WriteLine("\n>En este ejemplo se usa una cadena y con otra cadena usando el metodo: \"string.Format\" se le añade lo que se quieras.\n " + cadenaFormato1);

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("### METODOS PROPIOS DE LAS CADENAS: StartsWith, EndsWith Y EQUALS ###");
        string cdn = "s.o.s culo grande cinturita xs";
        Console.WriteLine("La cadena es: " + cdn);
        Console.WriteLine("¿Empieza por: \"SO\"?: " + cdn.StartsWith("SO"));
        Console.WriteLine("¿Empieza por: \"s.o\"?: " + cdn.StartsWith("s.o"));
        Console.WriteLine("¿Empieza por: \"XS\"?: " + cdn.EndsWith("XS"));
        Console.WriteLine("¿Empieza por: \"xs\"?: " + cdn.EndsWith("xs"));
        Console.WriteLine("¿Es igual que \"s.o.s culo grande cinturita xs?\": " + cdn.Equals("s.o.s culo grande cinturita xs"));

        Console.Write(mensaje);
        Console.ReadLine();

        Console.WriteLine("### METODOS PROPIOS DE LAS CADENAS: SUBSTRING, TRIMSTAR, TRIMEND Y TRIM ###");

        string st = "Me vas a permitir. Que salvaguarde mi felicidad. Que siga mi camino. No pido mucho más";
        string substring1 = st.Substring(0,39);
        string substring2 = st.Substring(12,12);
        Console.WriteLine(st);
        Console.WriteLine(substring1);
        Console.WriteLine(substring2);
        Console.WriteLine();
        st = " Dame un segundo";
        Console.WriteLine(st);
        Console.WriteLine(st.TrimStart());
        Console.WriteLine(st.TrimEnd());
        Console.WriteLine(st.Trim());

    }
}