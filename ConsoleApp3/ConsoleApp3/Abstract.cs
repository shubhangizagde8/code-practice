﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    //abstract

    //abstract class cannot have an object.
    //abstarct class can be extendend by any derived class
    //it can have constructor and destructors
    //it cannot sipport multiple inheritance
    //it cannot be static
    abstract class Sample
    {
        public abstract void print();
        public void show()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Sample2 : Sample
    {
        public override void print()
        {
            Console.WriteLine("Hello");
        }
    }


    class Abstract
    {
        static void Main6(string[] args)
        {

            Sample2 s = new Sample2();
            s.print();
            s.show();


        }

    }
}
