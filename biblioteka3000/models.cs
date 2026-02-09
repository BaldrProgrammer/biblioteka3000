namespace biblioteka3000;

public class Models
{
    public abstract class Multimedia
    {
        private string title;
        private string author;
        private int year;
        private bool genre;
    }

    public class Ksiazka : Multimedia
    {
        private int pageLenght;
    }
}