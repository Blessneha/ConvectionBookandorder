using Demo2CodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Repositories
{
    internal class BookRepository
    {

        public Dbdemo2 dbdemo=new Dbdemo2();

        public void AddBook(Book b)
        {
            dbdemo.Books.Add(b);
            dbdemo.SaveChanges();
        }
        public List<Book>GetBooks()
        {
            return dbdemo.Books.ToList();
        }

        public Book GetBookByID(string n)
        {
            Book book = dbdemo.Books.Find(n);
            return book;
        }

        public void DeleteBooks(string r)
        {
            Book b = dbdemo.Books.Find(r);
            dbdemo.Books.Remove(b);
            dbdemo.SaveChanges();
        }

        public void EditBooks(Book boook)
        {
            Book o=dbdemo.Books.Find(boook.BookId);
            o.Author = boook.Author;
            dbdemo.SaveChanges();
        }
    }
}
