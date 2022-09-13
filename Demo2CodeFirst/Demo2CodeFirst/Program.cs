using Demo2CodeFirst.Entity;
using Demo2CodeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookRepository bookRepository = new BookRepository();
            OrderRepository order = new OrderRepository();
            do
            {
                Console.WriteLine("1.AddOrder\n2.AddBook\n3.GetBooks\n4.GetEmployee\n5.DeleteBooks" +
                    "\n6.EditBooks");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Order o=new Order() {OrderId=1,OrderDate=DateTime.Now,BookId="1"};
                            order.PlaceOrder(o);
                             
                        }
                        break;
                    case 2:
                        {
                            Book b = new Book();
                            Console.WriteLine("Enter BookId");
                             b.BookId=Console.ReadLine();
                            Console.WriteLine("Enter BookNname");
                            b.BookName=Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            b.Price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author");
                            b.Author = Console.ReadLine();
                            bookRepository.AddBook(b);



                        }
                        break;
                    case 3:
                        {
                            List<Book> books = bookRepository.GetBooks();
                            foreach (var b in books)
                                Console.WriteLine($"BOOKID:{b.BookId} BOOKName:{b.BookName} Price:{b.Price} Author:{b.Author}");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter BookId");
                            string id = Console.ReadLine();
                            Book b = bookRepository.GetBookByID(id);
                            Console.WriteLine($"BOOKID:{b.BookId} BOOKName:{b.BookName} Price:{b.Price} Author:{b.Author}");

                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter BookId");
                            string id = Console.ReadLine();
                            bookRepository.DeleteBooks(id);
                        }
                        break;
                    case 6:
                        {
                            Book b = new Book();
                            Console.WriteLine("Enter BookId");
                            b.BookId = Console.ReadLine();
                            Console.WriteLine("Enter BookNname");
                            b.BookName = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            b.Price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author");
                            b.Author = Console.ReadLine();
                            bookRepository.EditBooks(b);
                        }
                        break;

                }
            } while (true);
        }
    }
}
