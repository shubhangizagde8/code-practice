using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace ConsoleApp3
{
    class collection
    {
        public void sq()
        {
            Console.WriteLine("================");
            //sortedlist
            //it is a class that has the combination of arraylist and hashtable
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            //stack
            //LIFO
            Console.WriteLine("================");
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            //queue
            //FIFO
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        public void st()
            {
            ArrayList al = new ArrayList();
            string str = "shubhangi";
            int x = 10;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Add(3.77);
            // al.Remove(d);

            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" \n");
        }
        public static void Main10()
        {
            collection c = new collection();
            c.sq();
            //c.st();

        }

    }
}
