namespace biblioteka3000
{
    public interface IRental
    {
        void Take(User user, Multimedia multimedia);
        void Return(User user, Multimedia multimedia);
    }
    
    public interface IRatable
    {
        void Rate(User user, Multimedia multimedia, int rate);
    }
}