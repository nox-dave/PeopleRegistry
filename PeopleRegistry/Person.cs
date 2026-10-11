namespace PeopleRegistry;

/// <summary>
/// </summary>
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Address Address { get; set; } = new Address();
    public Company Company { get; set; } = new Company();
}
