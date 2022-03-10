using System;

namespace ejercicio4 
{
    class program
    {
        private static string? suma;

        static void Main(string[] args)
        {
            int n = 1;
            int n1 = 1; 
            int d1 = 2;
            int n2 = 1;
            int d2 = 3;
            int n3 = 1;
            int d3 = 0;
            
           

            System.Console.WriteLine("Dame el tercer denominador");
            d3 = int.Parse(System.Console.ReadLine());

            if (d3 >= 0)
            {
                object p =  (n, n1, d1, n2, d2, n3, d3);

                int t1 = 0;
                int t2 = 0;
                int t3 = 0;
                int dCom = 0;
                int nR = 0;

                dCom = d1 * d2 * d3;

                t1 = (dCom / d1) * n1;

                t2 = (dCom / d2) * n2;

                t3 = (dCom / d3) * n3;

                nR = t1 + t2 + t3;

                Console.WriteLine("{0} + {1}/{2} + {3}/{4} + {5}/{6} = {7}/{8}", n, n1, d1, n2, d2, n3, d3, nR, dCom);
            }
                
            
        }
    }
}