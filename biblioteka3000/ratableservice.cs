namespace biblioteka3000;

public class RatableService : IRatable
{
    public void Rate(User user, Multimedia multimedia, int rate)
    {
        if (rate > 0 | rate <= 10)
        {
            
        }
    }
}