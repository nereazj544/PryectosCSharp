using System.Security.Cryptography.X509Certificates;

namespace OBJETOSBASICA
{
    class Punto
    {
        /*
        int X;
        int Y;
        public Punto()
        {
            X = 0;
            Y = 0;
        }
        public Punto(int x, int y)
        {
            Y = y;
            X = x;

        }

        public void SetX(int x)
        {
            X = x;
        }
        public void SetY(int y)
        {
            Y = y;
        }

*/
        /*
        int X;
        int Y;
        public Punto(int x, int y)
        {
            Y = y;
            X = x;

        }
        public void SetX(int x)
        {
            X = x;
        }
        public void SetY(int y)
        {
            Y = y;
        }

*/

        int X;
        int Y;
        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public void SetX(int x)
        {
            X = x;
        }
        public void SetY(int y)
        {
            Y = y;
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public void MostrarPunto()
        {
            System.Console.WriteLine("El punto es({0}, {1})", X, Y);
        }
    }

}
