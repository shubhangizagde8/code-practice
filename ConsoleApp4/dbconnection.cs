using System;
using ConsoleApp4.Models;
using System.Linq;


namespace ConsoleApp4
{
    
    // Scaffold-DbContext "Data Source=DESKTOP-S0BV6A2;Initial Catalog=SampleDb1;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
    class dbconnection
    {
        static void Main(string[] args)
        {
            
            SampleDbContext db = new SampleDbContext();
            var data = db.Tblsamples;




            int ch = 0;
            while (ch != 5)
            {
                Console.WriteLine("1:insert data");
                Console.WriteLine("2:show table data");
                Console.WriteLine("3:delete data");
                Console.WriteLine("4:update data");
                Console.WriteLine("5:Exit");
                Console.WriteLine(" ");

                Console.Write("Pleae enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (ch)
                {
                    case 1:
                        Console.Write("Plese enter name :");
                        string name = Console.ReadLine();
                        Tblsample tblsample = new Tblsample();
                        tblsample.Text = name;
                        db.Tblsamples.Add(tblsample);
                        db.SaveChanges();
                        Console.WriteLine(" ");
                        Console.WriteLine("recoed after insertion: ");
                        Console.WriteLine(" ");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Id + " | " + item.Text);
                        }
                        Console.WriteLine("\n ");

                        break;
                    case 2:


                       // Console.WriteLine("Values from database ");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Id + " | " + item.Text);
                        }
                        Console.WriteLine("\n ");
                        break;

                    case 3:

                        Console.Write("Pleae enter id of your name which you want to delete: ");
                        int DeleteItem = Convert.ToInt32(Console.ReadLine());
                        var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
                        db.Tblsamples.Remove(DeleteObject);
                        db.SaveChanges();
                        Console.WriteLine(" ");
                        Console.WriteLine("recoed after delete: ");
                        Console.WriteLine(" ");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Id + " | " + item.Text);
                        }
                        Console.WriteLine("\n ");
                        break;

                    case 4:
                        Console.Write("Pleae enter id of your name which you want to update: ");
                        int InsertItem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please enter the new name : ");
                        var newName = Console.ReadLine();
                        var UpdateObject = db.Tblsamples.Where(x => x.Id == InsertItem).FirstOrDefault();
                        UpdateObject.Text = newName;
                        db.Tblsamples.Update(UpdateObject);
                        db.SaveChanges();
                        Console.WriteLine(" ");
                        Console.WriteLine("recoed after update: ");
                        Console.WriteLine(" ");

                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Id + " | " + item.Text);
                        }

                        Console.WriteLine("\n ");
                        break;

                    case 5:
                        Console.WriteLine(" exiting from program:");
                        break;
                    default:
                        Console.WriteLine(" pleae enter correct choice:\n");
                        break;



                }
            }
        }
    }
}
