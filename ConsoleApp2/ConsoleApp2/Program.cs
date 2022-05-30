using System;

namespace ConsoleApp2
{


    class student
    {
        public string Name;
        public int Eid;
        public string Gender;
        public int salary;
        public string cname;

        //get Input from User

        //Methods in a class

        public student()
        {
            cname = "capgemini";
        }

        public void GetData()
        {
            Console.WriteLine("Please enter Employee Details:");
            Console.WriteLine("Please enter Employee Name");
            Name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please enter Employee ID Number");
            Eid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Please enter Employee Gender");
            Gender= Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please enter Employee salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n");
        }

        public void PrintData()
        {
           
            Console.WriteLine(Name+"\t"+Eid+"\t\t"+Gender+"\t"+salary+"\t"+cname);
            
            Console.WriteLine(" ");
        }

      
    }


    class SampleClass
    {
        int a, b;
        //Copy Constructor
        public SampleClass(SampleClass c)
        {
            a = c.a;
            b = c.b;
        }
        public SampleClass() { }
        public void SetValue(int _a)
        {
            a = _a;
        }
        public void printValue()
        {
            Console.WriteLine(a);
        }


    }

    class PropertiesInClass
    {
        // Acess specifier
        public PropertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private const double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void PrintCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    }


    class A
    {
        //super class
        protected int rn=10;

    }

    //derived class
    class B : A
    {
        public void Print()
        {
            Console.WriteLine(rn);
        }
    }


    public class Shape
    {
        // pollymorphism
        protected double length;
        protected double width;
    }

    public class Square : Shape
    {
        public Square(double side)
        {
            length = width = side;
        }

        public void PrintArea()
        {
            Console.WriteLine("Area of a square is: " + (length * width));
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public void PrintArea()
        {
            Console.WriteLine("Area of a Rectange is: " + (length * width));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  Console.Write("Please enter Number for factirial:");
            // int n = Convert.ToInt32(Console.ReadLine());
            //fact(n);


            /* x = 5, y = 6;
            Console.WriteLine("Before Swapping \na=" + x + "  b=" + y);
            Swap(ref x, ref y);
            Console.WriteLine("After Swapping \na=" + x + "  b=" + y);
            */

            //can recive multipe values from a function.
            /*int r2, r3, r4;
            x1(out r2, out r3, out r4);
            Console.WriteLine(" Multiple return value of function using out variable: "+r2 +" "+ r3 +" " + r4);

            int r1 = x12();
            Console.WriteLine("Retrn method of function : "+r1 );
            */

            //array of objects
            /*  student[] studentlist = new student[3];

              for (int i = 0; i < studentlist.Length; i++)
              {
                  student s = new student();
                  s.GetData();
                  studentlist[i] = s;
              }


              Console.WriteLine("Employee Details are");
              Console.WriteLine("Name\t" + "Employee id\t" + " Gender\t" + " salary\t"+"company name");
              for (int i = 0; i < studentlist.Length; i++)
              {
                  studentlist[i].PrintData();
              }*/

            /*
            // coopy constructer
            SampleClass S = new SampleClass();
            S.SetValue(1);
            SampleClass S1 = new SampleClass(S);
            S1.printValue();
            */

            /*
            // parameter constructer
            PropertiesInClass p = new PropertiesInClass(2.5);
            Console.WriteLine("Radius is " + p.radius);
            p.PrintCircumference();
            */

            /*
            //derived class
            B t = new B();
            t.Print();
            */



            // pollymorphism
            Rectangle r = new Rectangle(2.5, 5.2);
            r.PrintArea();
            Square s = new Square(2.5);
            s.PrintArea();
        }

         static void fact(int a)
         {
             int i,j=1;
             Console.WriteLine();
             for (i = a; i > 0; i--)
             {
                 j = j * i;
             }
             Console.WriteLine("factorial of number " +a +"  is: "+j);
         }

        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("In Swap Method \na=" + a + "  b=" + b);

        }


        /*
        // out keyword
        static void x1(out int s1, out int s2, out int s3)
        {
            s1 = 1;
            s2 = 1;
            s3 = 1;
        }

        static int x12()
        {
            return 3;
            return 2;

        }

        */
    }
}
