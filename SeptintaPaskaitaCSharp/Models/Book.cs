namespace SeptintaPaskaitaCSharp.Models
{
    public class Book
    {
        protected string Title { get; set; }
        protected string Author { get; set; }
        protected int Year { get; set; }

        public Book() { }

        protected Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }

}