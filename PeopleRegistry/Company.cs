namespace PeopleRegistry;

public class Company
{
    public string Name { get; set; } = string.Empty;
    public string Slogan { get; set; } = string.Empty;

    public void PrintCompany()
    {
        Console.WriteLine("Company: " + Name);
        Console.WriteLine("Slogan: " + Slogan);
    }
}
