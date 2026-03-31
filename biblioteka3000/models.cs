namespace biblioteka3000
{
    public abstract class Multimedia
    {
        private static List<Multimedia> s_multimedias = new List<Multimedia>();
        
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

        public string Type
        {
            get => _genre;
            set => _genre = value ?? throw new ArgumentNullException(nameof(value));
        }

        private string _type = "Multimedia";

        public int Rate
        {
            get => _rate;
            set => _rate = value;
        }

        private int _rate;

        public int PeopleRated
        {
            get => _pplrated;
            set => _pplrated = value;
        }


        private int _pplrated;

        public Multimedia(string title, string author, int year, int lenght, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Lenght = lenght;
            Genre = genre;
            Rate = 0;
            PeopleRated = 0;
            s_multimedias.Add(this);
        }

        public Multimedia(Multimedia other)
        {
            Title = other._title;
            Author = other._author;
            Year = other._year;
            Lenght = other._lenght;
            Genre = other._genre;
            Rate = other._rate;
            PeopleRated = other._pplrated;
            s_multimedias.Add(this);
        }

        public static List<Multimedia> GetMultimedias()
        {
            return s_multimedias;
        }

        public abstract string ShowInfo();

        ~Multimedia()
        {
            Console.WriteLine("Object has destroyed.");
        }
    }

    public class Book : Multimedia
    {
        public Book(string title, string author, int year, int lenght, string genre)
            : base(title, author, year, lenght, genre)
        {
            Type = "Book";
        }

        public override string ShowInfo()
        {
            return $"A Book written by {Author} in {Year} and named {Title}. Has {Lenght} pages. Genre is {Genre}. Rate is {Rate/PeopleRated} from {PeopleRated} people.";
        }
    }

    public class Movie : Multimedia
    {
        public Movie(string title, string author, int year, int lenght, string genre)
            : base(title, author, year, lenght, genre)
        {
            Type = "Movie";
        }

        public override string ShowInfo()
        {
            return $"A Movie filmed by {Author} in {Year} and named {Title}. Has {Lenght} minutes. Genre is {Genre}.";
        }
    }

    public class Game : Multimedia
    {
        public Game(string title, string author, int year, int lenght, string genre)
            : base(title, author, year, lenght, genre)
        {
            Type = "Game";
        }

        public override string ShowInfo()
        {
            return
                $"A Game developed by {Author} in {Year} and named {Title}. {Lenght}+- hours needs to be fully completed. Genre of the game is {Genre}.";
        }
    }
}