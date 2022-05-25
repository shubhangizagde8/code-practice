using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            for (k = 0; k >= 10; k++)
            {
                Console.WriteLine("*");
                Console.ReadLine();

            }

            Console.Write("Enter your choice:");

             int p= Convert.ToInt32(Console.ReadLine());
          
            switch (p)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WENSDAY");
                    break;
                case 4:
                    Console.WriteLine("THARSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATERDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;

                   default:
                    Console.WriteLine("Not AVAIBLE:");
                    Console.WriteLine("ENTER CHOICE BETWEEN 1 TO 7:");
                    break;
            }
            

            /*  Console.WriteLine("");
              Console.WriteLine("Enter number 1 :");
              int a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("");

              Console.WriteLine("Enter number 2:");
              int b = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("");

              Console.WriteLine("1 :Addition");
              Console.WriteLine("2:subastraction");
              Console.WriteLine("3:multiplication");
              Console.WriteLine("4:devision");
              Console.WriteLine("");

              Console.Write("Enter your choice for perform above operation:");
              int ch = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("");


              int r;

              switch (ch)
              {
                  case 1:
                      r = a + b;
                      Console.WriteLine("Addition is : "+r);

                      break;
                  case 2:
                      r = a - b;
                      Console.WriteLine("subastraction is: "+r);
                      break;
                  case 3:
                      r = a * b;
                      Console.WriteLine("multiplication is: "+r);
                      break;
                  case 4:
                      r = a / b;
                      Console.WriteLine("devision is: "+r);
                      break;

                  default:
                      Console.WriteLine("Not AVAIBLE:");
                      Console.WriteLine("ENTER CHOICE BETWEEN 1 TO 4:");
                      break;
              }*/







        }
    }
}
