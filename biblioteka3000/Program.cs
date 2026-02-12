using System.Text.Json;
using biblioteka3000;

{
    string? username = Console.ReadLine();
    string? password = Console.ReadLine();
    string text = File.ReadAllText("users.json");
    var json = JsonSerializer.Deserialize<Dictionary<string, string>>(text);
    
    foreach (var i in json)
    {
        if (i.Key == username)
        {
            if (i.Value == password)
            {
                Library library = Library.Instance;
                library.Archive = new List<Multimedia>();
                User user = new User(username, password, new List<Multimedia>());
                while (true)
                {
                    string? command = Console.ReadLine();
                    if (command.StartsWith("Add"))
                    {
                        List<string> commandargs1 = command.Split().ToList();
                        if (commandargs1[1] == "Book")
                        {
                            List<string> commandargs2 = commandargs1[2].Split(",").ToList();
                            Book instance = new Book(
                                commandargs2[0],
                                commandargs2[1],
                                int.Parse(commandargs2[2]),
                                int.Parse(commandargs2[3]),
                                commandargs2[4]
                            );
                            library.Archive.Add(instance);
                            Console.WriteLine("Added Book.");
                        }
                    }
                    
                    if (command.StartsWith("take"))
                    {
                        List<string> commandargs = command.Split().ToList();
                        IRental.Take(user, library.Archive[int.Parse(commandargs[1])]);
                    }
                    else if (command == "return")
                    {
                        IRental.Return(user, new Book("","",1,1,""));
                    }
                    else if (command == "my_library")
                    {
                        for (int ii = 0; ii < library.Archive.Count; ii++ )
                        {
                            Console.WriteLine($"{ii}. "+ library.Archive[ii].ShowInfo());
                        }
                    }
                    else if (command == "library")
                    {
                        Console.WriteLine(library.Archive);
                        for (int ii = 0; ii < library.Archive.Count; ii++ )
                        {
                            Console.WriteLine($"{ii}. "+ library.Archive[ii].ShowInfo());
                        }
                    }
                }
            }
        }
    }
}