namespace OBJETOBASICA.clases
{
    class Puntos
    {
        int X;
        int Y;

        public Puntos(int x, int y){
            X = x;
            X = y;
        }

        public void MostrarPunto(){
            System.Console.WriteLine("({0}, {1})", X, Y);
        }
    }
}
