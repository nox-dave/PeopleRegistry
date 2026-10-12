namespace PeopleRegistry;

internal class Program
{
    static void Main(string[] args)
    {
        var directory = new PeopleDirectory();
        var menu = new Menu(directory);
        menu.Run();
    }
}
