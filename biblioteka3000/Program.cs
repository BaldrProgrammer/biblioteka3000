using System.Text.Json;
using biblioteka3000;

{
    string? username = Console.ReadLine();
    string? password = Console.ReadLine();
    string text = File.ReadAllText("users.json");
    var json = JsonSerializer.Deserialize<Dictionary<string, string>>(text);
    Console.WriteLine(json);

    foreach (var i in json)
    {
        if (i.Key == username)
        {
            if (i.Value == password)
            {
                User user = new User(username, password, new List<Multimedia>());
                Console.WriteLine(user.Login);
            }
        }
    }
}