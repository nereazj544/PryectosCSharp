// See https://aka.ms/new-console-template for more information
using OBJETOBASICA.clases;
using OBJETOSBASICA;

class Program
{
    static void Main(string [] args){
        // Punto p = new Punto(3, 7);
        Punto p = new Punto();
        
        // p.MostrarPunto();
        // p.SetX(9);
        // p.SetY(2);
        // p.MostrarPunto();
        // p.X = 9;
        // p.Y = 3;
        p.MostrarPunto();
        p.SetY(2);
        p.SetX(4);

        p.MostrarPunto();

        System.Console.WriteLine("El valor X es: " + p.GetX());
        System.Console.WriteLine("El valor Y es: " + p.GetY());

        Puntos puntos1 = new Puntos(3, 5);
        Puntos puntos2 = new Puntos(1, 8);
        Puntos puntos3 = new Puntos(10, 9);
        Triangulo t = new Triangulo(puntos1, puntos2, puntos3);
        t.MostrarTriangulo();

    }
}