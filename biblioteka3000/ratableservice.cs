namespace biblioteka3000;

public class RatableService : IRatable
{
    public void Rate(Multimedia multimedia, int rate)
    {
        if (rate > 0 | rate <= 10)
        {
            multimedia.PeopleRated += 1;
            multimedia.Rate += rate;
        }
    }
}