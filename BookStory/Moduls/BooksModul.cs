using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStory.Moduls
{
    public class BooksModul
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string Author { get; set; }
        public string Descreption { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotalPage { get; set; }
    }
}
