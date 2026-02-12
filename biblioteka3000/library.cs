namespace biblioteka3000;

public sealed class Library
{
    private static Library? _instance;

    private List<Multimedia> _archive;
    public List<Multimedia> Archive
    {
        get => _archive;
        set => _archive = value ?? throw new ArgumentNullException(nameof(value));
    }

    private Library() { }

    public static Library Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Library();
            }
            return _instance;
        }
    }
}