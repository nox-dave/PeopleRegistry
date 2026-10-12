namespace PeopleRegistry;

public class HardcodedPeopleSource : IPeopleSource
{
    public List<Person> GetPeople()
    {
        return new List<Person>
        {
            new Person
            {
                Id = 14,
                Name = "Luke Skywalker",
                Email = "luke.skywalker@volvo.com",
                Address = new Address
                {
                    Street = "Drottninggatan 12",
                    PostalCode = "111 29",
                    City = "Stockholm"
                },
                Company = new Company
                {
                    Name = "Volvo",
                    Slogan = "For life"
                }
            },
            new Person
            {
                Id = 3,
                Name = "Han Solo",
                Email = "han.solo@ikea.com",
                Address = new Address
                {
                    Street = "Kungsgatan 4",
                    PostalCode = "411 03",
                    City = "Göteborg"
                },
                Company = new Company
                {
                    Name = "IKEA",
                    Slogan = "To create a better everyday life for the many people"
                }
            },
            new Person
            {
                Id = 21,
                Name = "Leia Organa",
                Email = "leia.organa@ericsson.com",
                Address = new Address
                {
                    Street = "Södergatan 8",
                    PostalCode = "211 20",
                    City = "Malmö"
                },
                Company = new Company
                {
                    Name = "Ericsson",
                    Slogan = "A world of communication"
                }
            },
            new Person
            {
                Id = 8,
                Name = "Yoda",
                Email = "yoda@hm.com",
                Address = new Address
                {
                    Street = "Sankt Olofsgatan 15",
                    PostalCode = "753 20",
                    City = "Uppsala"
                },
                Company = new Company
                {
                    Name = "H&M",
                    Slogan = "Fashion and quality at the best price"
                }
            },
            new Person
            {
                Id = 2,
                Name = "Darth Vader",
                Email = "darth.vader@spotify.com",
                Address = new Address
                {
                    Street = "Stora Södergatan 3",
                    PostalCode = "222 22",
                    City = "Lund"
                },
                Company = new Company
                {
                    Name = "Spotify",
                    Slogan = "Music for everyone"
                }
            },
            new Person
            {
                Id = 17,
                Name = "Pelle",
                Email = "pelle@sas.se",
                Address = new Address
                {
                    Street = "Stora Gatan 7",
                    PostalCode = "722 11",
                    City = "Västerås"
                },
                Company = new Company
                {
                    Name = "SAS",
                    Slogan = "We are travelers"
                }
            },
            new Person
            {
                Id = 5,
                Name = "Kalle",
                Email = "kalle@ica.se",
                Address = new Address
                {
                    Street = "Drottninggatan 9",
                    PostalCode = "702 10",
                    City = "Örebro"
                },
                Company = new Company
                {
                    Name = "ICA",
                    Slogan = "Varje dag lite bättre"
                }
            },
            new Person
            {
                Id = 11,
                Name = "Alice",
                Email = "alice@electrolux.com",
                Address = new Address
                {
                    Street = "Storgatan 18",
                    PostalCode = "582 22",
                    City = "Linköping"
                },
                Company = new Company
                {
                    Name = "Electrolux",
                    Slogan = "Shape living for the better"
                }
            },
            new Person
            {
                Id = 9,
                Name = "Bob",
                Email = "bob@telia.com",
                Address = new Address
                {
                    Street = "Kullagatan 6",
                    PostalCode = "252 20",
                    City = "Helsingborg"
                },
                Company = new Company
                {
                    Name = "Telia",
                    Slogan = "The power to connect"
                }
            },
            new Person
            {
                Id = 6,
                Name = "Charlie",
                Email = "charlie@scania.com",
                Address = new Address
                {
                    Street = "Kungsgatan 44",
                    PostalCode = "903 26",
                    City = "Umeå"
                },
                Company = new Company
                {
                    Name = "Scania",
                    Slogan = "Driving the shift"
                }
            }
        };
    }
}
