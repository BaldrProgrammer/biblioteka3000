namespace biblioteka3000
{
    public interface IRental
    {
        public static void Take(User user, Multimedia multimedia)
        {
            user.Multimedias.Add(multimedia);
            Console.WriteLine($"a {multimedia.} with name {multimedia.Title} was added to {user.Login}'s library.");
        }
    }
}