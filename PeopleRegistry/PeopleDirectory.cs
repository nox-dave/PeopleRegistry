namespace PeopleRegistry;

public class PeopleDirectory
{
    private readonly IPeopleSource _peopleSource;

    public PeopleDirectory(IPeopleSource peopleSource)
    {
        _peopleSource = peopleSource;
    }

    public void ShowAllById()
    {
        List<Person> people = _peopleSource.GetPeople();
        PrintPeople(people.OrderBy(p => p.Id));
    }

    public void ShowTopFiveById()
    {
        List<Person> people = _peopleSource.GetPeople();
        PrintTopPeople(people.OrderBy(p => p.Id));
    }

    public void ShowAllByName()
    {
        List<Person> people = _peopleSource.GetPeople();
        PrintPeople(people.OrderBy(p => p.Name));
    }

    public void ShowTopFiveByName()
    {
        List<Person> people = _peopleSource.GetPeople();
        PrintTopPeople(people.OrderBy(p => p.Name));
    }

    /// <summary>
    /// Prints people whose names contain the search text, sorted by id.
    /// </summary>
    public void SearchByName(string searchText)
    {
        string trimmedName = searchText.Trim();
        if (trimmedName == "")
        {
            Console.WriteLine("Please enter a search text.");
            return;
        }

        string lowerCaseName = trimmedName.ToLower();
        List<Person> people = _peopleSource.GetPeople();
        var matches = people.Where(p => p.Name.ToLower().IndexOf(lowerCaseName) >= 0).OrderBy(p => p.Id);

        int numberShown = 0;
        foreach (Person person in matches)
        {
            person.PrintPerson();
            numberShown++;
        }

        if (numberShown == 0)
        {
            Console.WriteLine("No people found.");
        }
    }

    private void PrintPeople(IEnumerable<Person> people)
    {
        foreach (Person person in people)
        {
            person.PrintPerson();
        }
    }

    private void PrintTopPeople(IEnumerable<Person> people)
    {
        int numberShown = 0;
        foreach (Person person in people)
        {
            if (numberShown == 5)
            {
                return;
            }

            person.PrintPerson();
            numberShown++;
        }
    }
}
