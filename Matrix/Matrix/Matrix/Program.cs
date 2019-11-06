using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mymatrix = new Matrix();
            mymatrix.MakeMatrix();
            mymatrix.ShowMatrix();
            Console.WriteLine(new string ('-',20));
            mymatrix.CangeMatrix();
            mymatrix.MakeMatrix();
            mymatrix.ShowMatrix();

        }
    }
}
