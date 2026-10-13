# PeopleRegistry

Ett konsolprogram som visar, söker och sorterar personer.

## Köra programmet

Man behöver .NET SDK. Öppna PowerShell och gå till mappen där `PeopleRegistry.csproj` ligger.

```powershell
dotnet build
dotnet run
```

Utan argument visas menyn. Med argument körs kommandot och programmet avslutas.

```powershell
dotnet run -- list
dotnet run -- list --top5
dotnet run -- list --sort
dotnet run -- list --sort --top5
dotnet run -- list --search skywalker
```

`--` gör att argumenten går till programmet och inte till `dotnet`.

## Klasserna

Jag delade upp koden så att varje klass gör en sak.

`Person`, `Address` och `Company` är modellerna. Gata, postnummer och ort är en adress. Företagsnamn och slogan är ett företag. Därför ligger de i egna klasser i stället för som lösa fält på personen.

`IPeopleSource` har metoden `GetPeople()`. `HardcodedPeopleSource` har personerna i koden. `JsonPeopleSource` läser `people.json`. `PeopleDirectory` sorterar, söker och skriver ut. `Menu` är menyn och `CommandHandler` läser argumenten. Båda anropar samma metoder i `PeopleDirectory`. `Program` skapar objekten och väljer meny eller kommandorad.

## Byta datakälla

I `Program.cs` står det:

```csharp
IPeopleSource peopleSource = new HardcodedPeopleSource();
```

Byt till `new JsonPeopleSource()` om personerna ska läsas från `people.json`. Filen ska ligga i mappen man kör ifrån.

`PeopleDirectory` behöver inte ändras. Den känner bara till interfacet och anropar `GetPeople()`. Vilken klass som skapas bestäms i `Program`.

## C# och .NET

C# är språket. .NET är plattformen, med bibliotek och det som kör programmet. `Console` och filläsning kommer från .NET.

JavaScript används mycket i webbläsaren och man behöver inte ange typ på samma sätt. I C# talar man om vilken typ en variabel har, och koden kompileras innan den körs. Med C# och .NET kan man göra konsolprogram, webb-API:er och spel.

## Verktyg

Visual Studio är där man skriver koden och felsöker. Git sparar historiken så man kan gå tillbaka. PowerShell är terminalen där man kör `dotnet build` och `dotnet run`.

En commit är ett sparat läge, med ett meddelande om vad som ändrats. En branch är en egen linje av arbetet. Man kan till exempel jobba på `develop` och slå ihop den med `main` när det fungerar.
