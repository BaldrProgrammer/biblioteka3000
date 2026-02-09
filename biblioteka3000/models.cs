namespace biblioteka3000;

public class Models
{
    public abstract class Multimedia
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private int Year { get; set; }
        private int Lenght { get; set; }
        private string Genre { get; set; }

        public Multimedia(string title, string author, int year, int lenght, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Lenght = lenght;
            Genre = genre;
        }
    }

    public class Book : Multimedia
    {
        public Book(string title, string author, int year, int lenght, string genre)
            : base(title, author, year, lenght, genre)
        {
        }
    }
    
    public class Film : Multimedia
    {
        public Film(string title, string author, int year, int lenght, string genre)
            : base(title, author, year, lenght, genre)
        {
        }
    }
}