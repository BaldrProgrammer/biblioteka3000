namespace biblioteka3000;

public class Models
{
    public abstract class Multimedia
    {
        private string title;
        private string author;
        private int year;
        private string genre;

        public Multimedia(string title, string author, int year, string genre)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.genre = genre;
        }
    }

    public class Book : Multimedia
    {
        private int pageLenght;

        public Book(string title, string author, int year, int pageLenght, string genre)
            : base(title, author, year, genre)
        {
            this.pageLenght = pageLenght;
        }
    }
}