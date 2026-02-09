namespace biblioteka3000;

public class Models
{
    public abstract class Multimedia
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private int Year { get; set; }
        private string Genre { get; set; }

        public Multimedia(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }
    }

    public class Book : Multimedia
    {
        private int PageLenght { get; set; }

        public Book(string title, string author, int year, int pageLenght, string genre)
            : base(title, author, year, genre)
        {
            PageLenght = pageLenght;
        }
    }
}