namespace biblioteka3000;

public class RentalService : IRental
{
    public void Take(User user, Multimedia multimedia)
    {
        user.Multimedias.Add(multimedia);
        Console.WriteLine($"a {multimedia.Type} with name {multimedia.Title} was added to {user.Login}'s library.");
    }

    public void Return(User user, Multimedia multimedia)
    {
        user.Multimedias.Remove(multimedia);
        Console.WriteLine(
            $"a {multimedia.Type} with name {multimedia.Title} was removed from {user.Login}'s library.");
    }
}