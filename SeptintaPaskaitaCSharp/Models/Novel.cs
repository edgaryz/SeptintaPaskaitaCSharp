namespace SeptintaPaskaitaCSharp.Models
{
    public class Novel : Book
    {
        public List<Book> NovelBooks { get; set; }

        public string Genre { get; set; }

        public Novel() { }
        public Novel(string genre, string title, string author, int year) : base(title, author, year)
        {
            Genre = genre;
            NovelBooks = new List<Book>();
        }

        public override string ToString()
        {
            return $"Novel book: Genre: {Genre}, Title: {Title}, Author: {Author}, Year: {Year}.";
        }

    }
}
