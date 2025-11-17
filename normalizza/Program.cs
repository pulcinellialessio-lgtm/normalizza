using System.Runtime.Intrinsics;

namespace normalizza
{
    internal class Program
    {
        static double[] normalizza(int[] v1)
        {
            double[] v2 = new double[v1.Length];

            for(int i = 0; i < v1.Length; i++)
            {
                if(i == 0)
                {
                    v2[i] = (v1[i] + v1[i] + v1[i + 1]) / 3; 
                }
                else if(i == v1.Length)
                {
                    v2[i] = (v1[i] + v1[i] + v1[i - 1]) / 3;
                }
                else
                {
                    v2[i] = (v1[i] + v1[i - 1] + v1[i + 1]) / 3;
                }
            }

            Console.Write("Il secondo vettore è " + v2);
            return v2;

        }
        static void Main(string[] args)
        {
            int[] v1 = { 4, 5, 2, 8, 5 };

            normalizza(v1);
        }
    }
}
