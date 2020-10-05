using BookStory.Moduls;
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
                new BooksModul(){Id=1,title="java",Author="HasanovKamol1"},
                new BooksModul(){Id=2,title="c#",Author="HasanovKamol2"},
                new BooksModul(){Id=3,title="php",Author="HasanovKamol3"},
                new BooksModul(){Id=4,title="c++",Author="HasanovKamol4"}

            };
        }
    }
}
