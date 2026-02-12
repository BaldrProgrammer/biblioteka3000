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
                    if (command == "take")
                    {
                        IRental.Take(user, wiedzmin);
                    }
                    else if (command == "return")
                    {
                        IRental.Return(user, wiedzmin);
                    }
                }
            }
        }
    }
}