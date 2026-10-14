namespace PeopleRegistry;

public class Menu
{
    private readonly PeopleDirectory _directory;

    public Menu(PeopleDirectory directory)
    {
        _directory = directory;
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            PrintMenu();
            Console.Write("Your choice: ");
            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    _directory.ShowAllById();
                    break;
                case 2:
                    _directory.ShowTopFiveById();
                    break;
                case 3:
                    _directory.ShowAllByName();
                    break;
                case 4:
                    _directory.ShowTopFiveByName();
                    break;
                case 5:
                    Search();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid menu choice.");
                    break;
            }
        }
    }

    private void Search()
    {
        Console.Write("Search text: ");
        string searchText = Console.ReadLine() ?? "";
        _directory.SearchByName(searchText);
    }

    private void PrintMenu()
    {
        Console.WriteLine(@"
1. Show all people sorted by id
2. Show the first five people sorted by id
3. Show all people sorted by name
4. Show the first five people sorted by name
5. Search people by name
6. Exit
");
    }
}
