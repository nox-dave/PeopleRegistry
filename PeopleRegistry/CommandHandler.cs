namespace PeopleRegistry;

public class CommandHandler
{
    private readonly string[] _args;
    private readonly PeopleDirectory _directory;

    public CommandHandler(string[] args, PeopleDirectory directory)
    {
        _args = args;
        _directory = directory;
    }

    public void Handle()
    {
        string command = _args.Length > 0 ? _args[0].ToLower() : "";

        if (command != "list")
        {
            Console.WriteLine("Invalid argument. Use list, --top5, --sort or --search.");
            return;
        }

        bool top5 = false;
        bool sort = false;
        bool hasSearch = false;
        string searchText = "";

        for (int i = 1; i < _args.Length; i++)
        {
            if (_args[i] == "--top5")
            {
                top5 = true;
            }
            else if (_args[i] == "--sort")
            {
                sort = true;
            }
            else if (_args[i] == "--search" && i + 1 < _args.Length)
            {
                hasSearch = true;
                searchText = _args[i + 1];
                i++;
            }
            else if (_args[i] == "--search")
            {
                hasSearch = true;
                searchText = "";
            }
            else
            {
                Console.WriteLine("Invalid argument. Use list, --top5, --sort or --search.");
                return;
            }
        }

        if (hasSearch)
        {
            _directory.SearchByName(searchText);
            return;
        }

        if (sort && top5)
        {
            _directory.ShowTopFiveByName();
            return;
        }

        if (sort)
        {
            _directory.ShowAllByName();
            return;
        }

        if (top5)
        {
            _directory.ShowTopFiveById();
            return;
        }

        _directory.ShowAllById();
    }
}
