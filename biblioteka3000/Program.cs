using System.Text.Json;
using biblioteka3000;

{
    string? username = Console.ReadLine();
    string? password = Console.ReadLine();
    string text = File.ReadAllText("users.json");
    var json = JsonSerializer.Deserialize<Dictionary<string, string>>(text);
    Console.WriteLine(json);
    
    Book wiedzmin = new Book( "Wiedźmin", "Andrzej Sapkowski", 1990, 320, "Fantasy" ); 
    Movie matrix = new Movie( "Matrix", "Wachowscy", 1999, 136, "Sci-Fi" );

    foreach (var i in json)
    {
        if (i.Key == username)
        {
            if (i.Value == password)
            {
                User user = new User(username, password, new List<Multimedia>());
                while (true)
                {
                    string? command = Console.ReadLine();
                    if (command == "Add")
                    {
                        List<string> commandargs1 = command.Split().ToList();
                        if (commandargs1[1] == "Book")
                        {
                            List<string> commandargs2 = commandargs1[2].Split(",").ToList();
                            Library library = Library.Instance;
                            Book instance = new Book(
                                commandargs2[0],
                                commandargs2[1],
                                int.Parse(commandargs2[2]),
                                int.Parse(commandargs2[3]),
                                commandargs2[4]
                            );
                            library.Archive.Add(instance);
                        }
                    }
                    
                    if (command == "take")
                    {
                        IRental.Take(user, wiedzmin);
                    }
                    else if (command == "return")
                    {
                        IRental.Return(user, wiedzmin);
                    }
                    else if (command == "library")
                    {
                        foreach (var multimedia in user.Multimedias)
                        {
                            Console.WriteLine(multimedia.ShowInfo());
                        }
                    }
                }
            }
        }
    }
}