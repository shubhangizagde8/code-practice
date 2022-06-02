﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    //overiding

    //virtual keyword
    //override


    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("I am coming from Base Class");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void show()
        {
            Console.WriteLine("I am coming from Derived Class");
        }
    }

    class Overridding
    {

        public static void Main5()
        {
            DerivedClass d = new DerivedClass();
            d.show();

            BaseClass obj;
            obj = new BaseClass();
            obj.show();

            obj = new DerivedClass();
            obj.show();
        }

    }
}
