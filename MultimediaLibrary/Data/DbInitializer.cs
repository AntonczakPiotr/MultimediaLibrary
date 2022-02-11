using MultimediaLibrary.Data;
using MultimediaLibrary.Enums;
using MultimediaLibrary.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            // Look for any persons.
            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var persons = new Person[]
            {
                new Person{FirstName="Adam",   LastName="Nowak",      DateOfBirth=DateTime.Parse("2019-09-01"), Gender=Gender.Male, Email="an@o2.pl"},
                new Person{FirstName="Anna",   LastName="Kowalczyk",  DateOfBirth=DateTime.Parse("2017-05-01"), Gender=Gender.Female, Email="ak@o2.pl"},
                new Person{FirstName="Kamil",  LastName="Anarski",    DateOfBirth=DateTime.Parse("2018-03-13"), Gender=Gender.Male},
                new Person{FirstName="Piotr",  LastName="Barzduk",    DateOfBirth=DateTime.Parse("2017-01-31"), Email="pb@o2.pl"},
                new Person{FirstName="Janina", LastName="Englert",    DateOfBirth=DateTime.Parse("2017-12-01"), Gender=Gender.Female, Email="je@o2.pl"},
                new Person{FirstName="Robert", LastName="Karpiński",  DateOfBirth=DateTime.Parse("2016-03-21"), Gender=Gender.Male, Email="rk@o2.pl"},
                new Person{FirstName="Laura",  LastName="Wiśniewska", DateOfBirth=DateTime.Parse("2018-07-28"), Gender=Gender.Female},
                new Person{FirstName="Norman", LastName="Oliński",    DateOfBirth=DateTime.Parse("2019-09-21")}
            };

            context.Persons.AddRange(persons);
            context.SaveChanges();

            var supplies = new Supply[]
            {
                new Supply{Title="Pan Tadeusz"       ,Author="Adam Mickiewicz",                MediaType=MediaType.Book,        Grade=Grade.F, Comment="Lektura"},
                new Supply{Title="Solaris"           ,Author="Stanislaw Lem",                  MediaType=MediaType.Audiobook,   Grade=Grade.A, Comment="Gruba"},
                new Supply{Title="Warsztat hakera"   ,Author="Matthew Hickey",                 MediaType=MediaType.Book,        Grade=Grade.D, Comment="Nudna"},
                new Supply{Title="The Division Bell" ,Author="Pink Floyd",                     MediaType=MediaType.CompactDisc, Grade=Grade.A},
                new Supply{Title="Grywalizacja"      ,Author="Paweł Tkaczyk",                  MediaType=MediaType.Audiobook,   Grade=Grade.B},
                new Supply{Title="Programista"       ,Author="Dom Wydawniczy Anna Adamczyk",   MediaType=MediaType.Journal},
                new Supply{Title="Zdjęcia z wakacji" ,Author="Jan Kowalczyk",                  MediaType=MediaType.Pendrive}
            };

            context.Supplies.AddRange(supplies);
            context.SaveChanges();

            var libraryCards = new LibraryCard[]
            {
                new LibraryCard{LibraryCardNumber = 26966504, PersonID = 2, State = State.Active,   ExpirationDate = DateTime.Parse("2019-09-01"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 77562431, PersonID = 6, State = State.Active,   ExpirationDate = DateTime.Parse("2017-05-01"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 62403592, PersonID = 7, State = State.Active,   ExpirationDate = DateTime.Parse("2018-03-13"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 60667318, PersonID = 4, State = State.Active,   ExpirationDate = DateTime.Parse("2017-01-31"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 75122476, PersonID = 4, State = State.Active,   ExpirationDate = DateTime.Parse("2017-12-01"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 32772122, PersonID = 3, State = State.Active,   ExpirationDate = DateTime.Parse("2016-03-21"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 20096738, PersonID = 8, State = State.Active,   ExpirationDate = DateTime.Parse("2018-07-28"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 23636983, PersonID = 4, State = State.InActive, ExpirationDate = DateTime.Parse("2019-09-21"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 88665978, PersonID = 3, State = State.Active,   ExpirationDate = DateTime.Parse("2019-09-21"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 84193876, PersonID = 1, State = State.Active,   ExpirationDate = DateTime.Parse("2019-09-21"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 79642231, PersonID = 2, State = State.InActive, ExpirationDate = DateTime.Parse("2019-09-21"), StartDate = DateTime.Parse("2013-07-28")},
                new LibraryCard{LibraryCardNumber = 54721218, PersonID = 5, State = State.Active,   ExpirationDate = DateTime.Parse("2018-07-28"), StartDate = DateTime.Parse("2013-07-28")}
            };

            context.LibraryCards.AddRange(libraryCards);
            context.SaveChanges();

            var activities = new Activity[]
            {
                new Activity{ActivityDate = DateTime.Parse("2018-02-28"),ActivityType=ActivityType.Borrowing,PersonID=8,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2018-07-18"),ActivityType=ActivityType.Borrowing,PersonID=1,SupplyID= 1},
                new Activity{ActivityDate = DateTime.Parse("2018-02-28"),ActivityType=ActivityType.Borrowing,PersonID=3,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2018-07-21"),ActivityType=ActivityType.Borrowing,PersonID=2,SupplyID= 4},
                new Activity{ActivityDate = DateTime.Parse("2018-03-28"),ActivityType=ActivityType.Borrowing,PersonID=2,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2018-07-23"),ActivityType=ActivityType.Borrowing,PersonID=5,SupplyID= 5},
                new Activity{ActivityDate = DateTime.Parse("2018-04-28"),ActivityType=ActivityType.Borrowing,PersonID=2,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2018-07-25"),ActivityType=ActivityType.Borrowing,PersonID=6,SupplyID= 6},
                new Activity{ActivityDate = DateTime.Parse("2018-05-18"),ActivityType=ActivityType.Borrowing,PersonID=2,SupplyID= 7},
                new Activity{ActivityDate = DateTime.Parse("2018-07-28"),ActivityType=ActivityType.Borrowing,PersonID=7,SupplyID= 1},
                new Activity{ActivityDate = DateTime.Parse("2018-06-18"),ActivityType=ActivityType.Borrowing,PersonID=1,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2018-07-28"),ActivityType=ActivityType.Borrowing,PersonID=1,SupplyID= 2},
            };

            context.Activities.AddRange(activities);
            context.SaveChanges();
        }
    }
}
