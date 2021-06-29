using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace DI_IoC
{

    interface IRepository
    {
        //BookContext Context { get; set; }
        void Save(Book b);
        IEnumerable<Book> List();
        Book Get(int id);
    }

    internal class Book
    {
    }

    class BookContext
    {
    }

    class BookRepository : IDisposable, IRepository
    {
        BookContext bd;

        //public BookContext Context 
        //{
        //завмисимость в свойствах
        //    get { return bd; } 
        //    set { bd = value; }
        //}

        public BookRepository(BookContext cont)
        {
            bd = cont;
        }

        public List<Book> GetList()
        {
            return new List<Book>() { };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save(Book b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> List()
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }
    }


    class HomeController: Controller
    {
        private BookRepository bookRepository;
        public HomeController()
        {
            //bookRepository = new BookRepository();
        }

        public ActionResult Index()
        {
            return View(bookRepository.GetList());
        }
    }
}
