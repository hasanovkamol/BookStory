using BookStory.Moduls;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BookStory.Respository
{
    public class BooksRespository
    {
        public List<BooksModul > GetAllBooks()
        {
           
            return DataSource();
        }
        public BooksModul GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BooksModul> SearchBook(string Title,string author)
        {
            return DataSource().Where(x => x.title.Contains(Title) || x.Author.Contains(author)).ToList();   
        }
        private List<BooksModul> DataSource()
        {
            return new List<BooksModul>
            {
                new BooksModul(){Id=1,title="java",Author="HasanovKamol",Descreption="This book  descreption for Java",Language="English",TotalPage=123,Category="Programing"},
                new BooksModul(){Id=2,title="c#",Author="Husanov Doston",Descreption="This book  descreption for C#",Language="English",TotalPage=976,Category="Programing"},
                new BooksModul(){Id=3,title="php",Author="Hasanov Shokir",Descreption="This book  descreption for PhP",Language="Uzbekcha",TotalPage=875,Category="Programing"},
                new BooksModul(){Id=4,title="c++",Author="Umarov Oxinjon",Descreption="This book  descreption fro C++",Language="Uzbekcha",TotalPage=654,Category="Cansept"},
                new BooksModul(){Id=5,title=".Net Core",Author="Umarov Oxinjon",Descreption="This book  descreption fro .Net Core",Language="Russia",TotalPage=154,Category="Framework"},
                new BooksModul(){Id=6,title="Javascrpt",Author="Umarov Oxinjon",Descreption="This book  descreption fro Javascrpt",Language="Russia",TotalPage=455,Category="Framework"}


            };
        }
    }
}
