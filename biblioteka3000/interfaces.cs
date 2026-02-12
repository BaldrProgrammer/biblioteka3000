namespace biblioteka3000
{
    public interface IRental
    {
        public static void Take(User user, Multimedia multimedia)
        {
            user.Multimedias.Add(multimedia);
            Console.WriteLine($"a {multimedia.Type} with name {multimedia.Title} was added to {user.Login}'s library.");
        }
        
        public static void Return(User user, Multimedia multimedia)
        {
            user.Multimedias.Remove(multimedia);
            Console.WriteLine($"a {multimedia.Type} with name {multimedia.Title} was removed from {user.Login}'s library.");
        }
    }
}