using System.Text.Json;

namespace PeopleRegistry;

public class JsonPeopleSource : IPeopleSource
{
    private readonly string _filePath = "people.json";

    public List<Person> GetPeople()
    {
        if (!File.Exists(_filePath))
        {
            return new List<Person>();
        }
        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
    }
}
