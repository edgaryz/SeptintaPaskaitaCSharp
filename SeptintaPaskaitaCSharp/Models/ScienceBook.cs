namespace SeptintaPaskaitaCSharp.Models
{
    public class ScienceBook : Book
    {
        List<Book> ScienceBooks { get; set; }

        public string Subject { get; set; }

        public ScienceBook() { }
        public ScienceBook(string subject, string title, string author, int year) : base(title, author, year)
        {
            Subject = subject;
            ScienceBooks = new List<Book>();
        }

        public override string ToString()
        {
            return $"Novel book: Subject: {Subject}, Title: {Title}, Author: {Author}, Year: {Year}.";
        }
    }
}
