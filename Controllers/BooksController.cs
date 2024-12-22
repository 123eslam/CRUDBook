using Microsoft.AspNetCore.Mvc;
using MVC1.Context;
using MVC1.Models;
using MVC1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class BooksController : Controller
    {
        
        //List<Books> book = new List<Books>()
        //{
        //    new Books()
        //    {
        //        Id=1,
        //        Name="Book1",
        //        Price=30,
        //        AuthorId=1,
        //        CategoryId=1
        //    },
        //    new Books()
        //    {
        //        Id=2,
        //        Name="Book2",
        //        Price=40,
        //        AuthorId=2,
        //        CategoryId=2
        //    },
        //    new Books()
        //    {
        //        Id=3,
        //        Name="Book3",
        //        Price=50,
        //        AuthorId=3,
        //        CategoryId=3
        //    },
        //};
        public IActionResult Index()
        {
            var context = new AppBooksContext();
            var Book = context.Books.ToList();
            return View(Book);
        }
        public IActionResult Details(int id)
        {
            var context = new AppBooksContext();
            var Book = context.Books.ToList();
            var d = Book.FirstOrDefault(b => b.Id == id);
            return View(d);
        }
        public IActionResult AddBook(int id)
        {
            var context = new AppBooksContext();
            var d =context.Books.FirstOrDefault(b => b.Id == id);
            ViewData["Auth"] = context.Authors.ToList();
            ViewData["Cat"] = context.Categories.ToList();
            return View(d);
        }
        public IActionResult SaveBook(AddBook addBook)
        {
            var context = new AppBooksContext();
            if (ModelState.IsValid)
            {
                var newbook = new Books()
                {
                    Name = addBook.Name,
                    Price = addBook.Price,
                    CategoryId = addBook.CategoryId,
                    AuthorId = addBook.AuthorId

                };
                context.Books.Add(newbook);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Auth"] = context.Authors.ToList();
                ViewData["Cat"] = context.Categories.ToList();
                var book = new Books()
                {
                    Name = addBook.Name,
                    Price = addBook.Price,
                    CategoryId = addBook.CategoryId,
                    AuthorId = addBook.AuthorId
                };
                return RedirectToAction("AddBook", book);
            }
        }
        public IActionResult UppdateBook(int id)
        {
            var context = new AppBooksContext();
            var d = context.Books.FirstOrDefault(b => b.Id == id);
            ViewData["Auth"] = context.Authors.ToList();
            ViewData["Cat"] = context.Categories.ToList();
            return View(d);
        }
        public IActionResult SaveUppdateBook(int id, UppdateBooks uppdate)
        {
            var context = new AppBooksContext();
            if (ModelState.IsValid)
            {
                var Book = context.Books.FirstOrDefault(c => c.Id == id);
                Book.Name = uppdate.Name;
                Book.Price = uppdate.Price;
                Book.AuthorId = uppdate.AuthorId;
                Book.CategoryId = uppdate.CategoryId;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Auth"] = context.Authors.ToList();
                ViewData["Cat"] = context.Categories.ToList();
                var Book = context.Books.FirstOrDefault(c => c.Id == id);
                Book.Name = uppdate.Name;
                Book.Price = uppdate.Price;
                Book.AuthorId = uppdate.AuthorId;
                Book.CategoryId = uppdate.CategoryId;
                return RedirectToAction("UppdateBook", Book);
            }
            
        }
        public IActionResult Delete(int id)
        {
            var context = new AppBooksContext();
            var book = context.Books.FirstOrDefault(b => b.Id == id);
            context.Books.Remove(book);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
