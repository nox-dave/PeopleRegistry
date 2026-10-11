namespace PeopleRegistry;

public class Address
{
    public string Street { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;

    public void PrintAddress()
    {
        Console.WriteLine("Street: " + Street);
        Console.WriteLine("Postal code: " + PostalCode);
        Console.WriteLine("City: " + City);
    }
}
