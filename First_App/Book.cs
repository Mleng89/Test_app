using System;
namespace First_App
{
    public class Book
    { 
            public string? title;
            public string? author;
            public int pages;
        public Book(string aTitle, string aAuthor, int aPages)
        {
            //Contrustor
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}

