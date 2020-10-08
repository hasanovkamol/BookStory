using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStory.Moduls;
using BookStory.Respository;
using Microsoft.AspNetCore.Mvc;

namespace BookStory.Controllers
{
    public class BookController : Controller
    {
        private readonly BooksRespository _respository = null;
        public BookController()
        {
            _respository = new BooksRespository();
        }
        public IActionResult  GetAllBook()
        {
           
            var data= _respository.GetAllBooks();
            return View(data);
        }
        public IActionResult GetBook(int id)
        {
            var data=_respository.GetBookById(id);
            return View(data);
        }
        public List<BooksModul> SearchBooks(string title,string Authorname)
        {
            return _respository.SearchBook(title,Authorname);
        }
    }
}
