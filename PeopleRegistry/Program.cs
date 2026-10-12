namespace PeopleRegistry;

internal class Program
{
    static void Main(string[] args)
    {
        IPeopleSource peopleSource = new HardcodedPeopleSource();
        var directory = new PeopleDirectory(peopleSource);

        if (args.Length == 0)
        {
            var menu = new Menu(directory);
            menu.Run();
            return;
        }

        var commandHandler = new CommandHandler(args, directory);
        commandHandler.Handle();
    }
}
