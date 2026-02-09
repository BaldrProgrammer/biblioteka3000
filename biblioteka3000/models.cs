namespace biblioteka3000
{
    public abstract class Multimedia
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        private string _author;

        public string Author
        {
            get => _author;
            set => _author = value ?? throw new ArgumentNullException(nameof(value));
        }

        private int _year;

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        private int _lenght;

        public int Lenght
        {
            get => _lenght;
            set => _lenght = value;
        }

        private string _genre;

        public string Genre
        {
            get => _genre;
            set => _genre = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Multimedia(string title, string author, int year, int lenght, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Lenght = lenght;
            Genre = genre;
        }

        public virtual string ShowInfo()
        {
            return
                $"A Multimedia with title {Title}, authorship {Author}, whis is {Year} year and {Genre}. It has {Lenght} of something lenght.";
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