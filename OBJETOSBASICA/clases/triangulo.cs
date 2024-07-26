namespace OBJETOBASICA.clases
{
    class Triangulo {
        Puntos P1;
        Puntos P2;
        Puntos P3;

        public Triangulo(Puntos p1, Puntos p2, Puntos p3){
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public void MostrarTriangulo(){
            System.Console.WriteLine("TRIANGULO COMPUESTO POR LOS SIGUIENTES PUNTOS: ");
            P1.MostrarPunto();
            P2.MostrarPunto();
            P3.MostrarPunto();
        }
    }
}
