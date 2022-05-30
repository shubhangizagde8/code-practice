using System;
using System.Collections.Generic;
using System.Text;

 namespace ConsoleApp3
{
    class PhotoBook
    {
        protected int numpages;

        public PhotoBook()
        {
            numpages = 16;
        }
        public PhotoBook(int _numpages)
        {
            numpages = _numpages;
        }
        public int GetNumberPages()
        {
            return numpages;
        }
    }

    class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numpages = 64;
        }
    }
    

        class Class1
    {
        static void Main2(string[] args)
        {
            PhotoBook p = new PhotoBook();
            Console.WriteLine(p.GetNumberPages());
            PhotoBook p1 = new PhotoBook(24);
            Console.WriteLine(p1.GetNumberPages());
            BigPhotoBook b = new BigPhotoBook();
            Console.WriteLine(b.GetNumberPages());

        }

    }
}
