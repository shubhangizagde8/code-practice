using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class shape1
    {
        //protected Location c;
        public string tostring()
        {
           return "string";
        }

        public double area()
        {
            return 2.30;
        }

        public double parameter()
        {
            return 30.30;
        }
    }

    public class rectangle : shape1
    {
        protected double side1;
        protected double side2;
    }

    public class circle : shape1
    {
        protected double radious;
    }

    public class location : shape1
    {
        private double x;
        private double y;
    }



    class Class2
    {
        public static void Main9(String[] args)
        {
            shape1 d = new shape1();
            Console.WriteLine(d.tostring());
            Console.WriteLine(d.area());
            Console.WriteLine(d.parameter());

        }
    }
}
