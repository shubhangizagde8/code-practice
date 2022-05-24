
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   int k;
               for (k = 1; k <= 10; k++)
               {
                   for (int j = 1; j <= k; j++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine("");
               }*/
            /* int k;
             for (k = 1; k <= 10; k++)
             {
                 for (int j = 1; j<=10; j++)
                 {

                     Console.Write(" ");
                     if (k == j)
                     {
                         Console.Write("*");
                     }
                     if (j==1)
                     {
                         Console.Write("*");
                     }
                    else if(j==10)
                     {
                         Console.Write("*");

                     }
                     else if (k==1 &&   j<8)
                     {
                         Console.Write("*");

                     }
                     else if (k==10 && j<8)
                     {
                         Console.Write("*");

                     }

                     else if (k+j==11)
                     {
                         Console.Write("*");

                     }
                     else
                     {
                         Console.Write("");

                     }
                 }
                     Console.WriteLine("");

             }*/

            int k;
            for (k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (k < j )
                    {
                        Console.Write("*");
                    }
                    

                }

                Console.WriteLine("");
            }

            for (k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {

                    if (k > j)
                        Console.Write("*");
                }

                Console.WriteLine("");
            }



            /*int b = 10;
          if (b%2==0)
          {
              Console.WriteLine("NUMBER IS EVEN");
          }
          else
              {
              Console.WriteLine("number is odd");
          }


          int c = 64;
          if (c > 18)
          {
              Console.WriteLine("he can give vote");
          }
          if (c > 60)
          {
              Console.WriteLine("BUT he is a senior citizen ");
          }
          else if (c<18)
          {
              Console.WriteLine("he is tin ager ");
          }
          else
          {
              Console.WriteLine("he can not giev vote");
          }

          */

            Console.ReadKey();



        }
    }
}
