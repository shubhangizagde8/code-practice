using System;

namespace ConsoleApp3
{
    public class person
    {
        public void StudentProfessorTest()
        {
            

            Console.WriteLine("1: create sudent");
            Console.WriteLine("2: create teacher");

            Console.Write("enter your choice : ");
           int  c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (c)
            {
                case 1:
                    //teacher p2 = new teacher();
                    student s1 = new student();
                    s1.cs();

                    break;
                case 2:
                    teacher t1 = new teacher();
                    t1.ct();

                    break;
             default:
                    break;
            }

        }
        }

    class student : person
    {
        int x;
        public void cs()
            {
            int i;
            Console.WriteLine("hello : ");
            Console.Write("enter student age: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            ShowAge(x);
            studdy();
        }
        public void ShowAge(int t)
        {
            
            Console.WriteLine("My age is: " + t + " years old on the screen.");
        }

        public void studdy()
        {
            Console.WriteLine("i am studding on screen");
        }
    }

    class teacher: person
    {
        public void ct()
        {
            int i;
            Console.WriteLine("hello : ");
            Console.Write("enter  teacher age: ");
             i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
           
            Console.WriteLine("My age is: " + i+ " years old on the screen.");
            
            Explain();
        }
        public void Explain()
        {
            
            Console.WriteLine("I'm explaining on the screen.");
            
        }
    }


    class Program
    {
        static void Main1(string[] args)
        {
            person p1 = new person();
            p1.StudentProfessorTest();

        }
    }
}
