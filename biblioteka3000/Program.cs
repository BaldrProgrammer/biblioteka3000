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
                    else if (command == "Save")
                    {
                        string userLibraryJson = JsonSerializer.Serialize(user.Multimedias, new JsonSerializerOptions { WriteIndented = true });
                        string libraryJson = JsonSerializer.Serialize(library.Archive, new JsonSerializerOptions { WriteIndented = true });

                        File.WriteAllText("user_library.json", userLibraryJson);
                        File.WriteAllText("library.json", libraryJson);
                    }
                    
                    if (command.StartsWith("take"))
                    {
                        List<string> commandargs = command.Split().ToList();
                        int index = int.Parse(commandargs[1]);
                        IRental.Take(user, library.Archive[index]);
                        library.Archive.RemoveAt(index);
                    }
                    else if (command.StartsWith("return"))
                    {
                        List<string> commandargs = command.Split().ToList();
                        int index = int.Parse(commandargs[1]);
                        IRental.Return(user, user.Multimedias[index]);
                        library.Archive.Insert(index, user.Multimedias[index]);
                    }
                    else if (command == "my_library")
                    {
                        for (int ii = 0; ii < user.Multimedias.Count; ii++ )
                        {
                            Console.WriteLine($"{ii}. "+ user.Multimedias[ii].ShowInfo());
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