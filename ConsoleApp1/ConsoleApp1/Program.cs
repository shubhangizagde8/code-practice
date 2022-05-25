
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //star pattern


            /*   int k;
               for (k = 1; k <= 10; k++)
               {
                   for (int j = 1; j <= k; j++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine("");
               }*/



            // star pattern
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



            //star pattern

            /*  int k;
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
              }*/

            // Even odd number

            /*int b = 10;
          if (b%2==0)
          {
              Console.WriteLine("NUMBER IS EVEN");
          }
          else
              {
              Console.WriteLine("number is odd");
          }


            // votting age

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


            //pallindrome

            /*string ins, rs=string.Empty;
            Console.Write("Enter a string : ");
            ins = Console.ReadLine();
            if (ins != null)
            {
                for (int i = ins.Length - 1; i >= 0; i--)
                {
                    rs += ins[i].ToString();
                }
                if (rs == ins)
                {
                    Console.WriteLine("String is Palindrome ");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome");
                }
            }*/


            //count douplicate number in array

            /*  int[] ar1 = new int[] { 1, 2, 3, 4, 5,3,4,7,9,5 };
              int i, j,c=0;

              for ( i = 0; i < ar1.Length; i++)
              {
                  for (j = i+1; j< ar1.Length; j++)
                  {
                      if (ar1[i]==ar1[j])
                      {
                          c++;
                      }
                  }

              }

              Console.WriteLine("Duplicate numbers : "+c);*/

            //find out second highest number


            /*int[] ar1 = new int[] { 20,21,10,4,30,78,32,12};
            int i, j, c ;

            Console.WriteLine("arry numbers is : " );
            for (i = 0; i < ar1.Length; i++)
            {
                Console.Write(ar1[i] + " ");
            }

            for (i = 0; i < ar1.Length; i++)
            {
                for (j = i + 1; j < ar1.Length; j++)
                {
                    if (ar1[j]>=ar1[i])
                    {
                        c = ar1[i];
                        ar1[i] = ar1[j];
                        ar1[j] = c;
                    }
                }
            }
            Console.WriteLine( " ");
            Console.Write("second highest number is: "+ar1[1] );

            */


            //matrics multiplication
            /*
            int i, j, m, n;
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            Console.WriteLine("ENTER 4 VALUE FOR MRATRIX OF: "+"["+"2"+","+"2"+"]");
            for (int r = 0; r < 2; r++)
            {
                for (int c= 0; c < 2; c++)
                {
                    Console.WriteLine("ENTER ELEMENT: ");
                    //Console.WriteLine("Please enter the value for arr1[" + r + "," + c + "]: ");
                    arr1[r, c] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();

             for (int row = 0; row < 2; row++)
             {
                 for (int col = 0; col < 2; col++)
                 {
                     Console.WriteLine("Please enter the value for arr2[" + row + "," + col + "]: ");
                     arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                 }
             }
             Console.WriteLine();
             Console.WriteLine();

             for (i = 0; i < 2; i++)
             {
                 for (j = 0; j < 2; j++)
                 {
                     arr3[i, j] = 0;
                     for (int k = 0; k < 2; k++)
                     {
                         arr3[i, j] += arr1[i, k] * arr2[k, j];
                     }
                 }
             }
             Console.WriteLine();
             Console.WriteLine("MULTIPLICATION OF MATRICS IS: ");
             Console.WriteLine();
            



            Console.WriteLine();
            Console.WriteLine();

            // transpose of matrix

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine();

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    arr2[j,i] = arr1[i,j] ;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("TRANSPOSE OF MATRICS IS: ");
            Console.WriteLine();

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }*/



            // unique number in array
            /*
            int n, c = 0;
            int[] a = new int[100];
            int i, j, k;

            Console.Write("Enter size of array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + n + " element in array");
            for (i = 0; i < n; i++)
            {
                Console.Write("Enter elemeny :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe unique elements  in array  :");
            for (i = 0; i < n; i++)
            {
                c = 0;
                
                for (j = 0; j < i - 1; j++)
                {
                    
                    if (a[i] == a[j])
                    {
                        c++;
                    }
                }
                
                for (k = i + 1; k < n; k++)
                {
                   
                    if (a[i] == a[k])
                    {
                        c++;
                    }
                    
                    if (a[i] == a[i + 1])
                    {
                        i++;
                    }
                }
                
                if (c== 0)
                {
                    Console.Write(" ," + a[i]);
                }
            }*/

            int[][] jaggged_array = new int[][]
            {
                new int[] { 1,2},
                new int[] { 1,2,3,4,5},
                new int[] { 1,2,3,4,5,6,7,8},
                new int[] { 1,2,3,4,5,6,7,8,9,10}
            };

            for (int i = 0; i < jaggged_array.Length; i++)
            {
                for (int j = 0; j < jaggged_array[i].Length; j++)
                {
                    Console.Write(jaggged_array[i][j]);
                }
                Console.WriteLine();
            }



            Console.ReadKey();



        }
    }
}
