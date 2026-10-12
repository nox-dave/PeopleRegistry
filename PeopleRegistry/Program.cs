namespace PeopleRegistry;

internal class Program
{
    static void Main(string[] args)
    {
        IPeopleSource peopleSource = new HardcodedPeopleSource();
        var directory = new PeopleDirectory(peopleSource);
        var menu = new Menu(directory);
        menu.Run();
    }
}
