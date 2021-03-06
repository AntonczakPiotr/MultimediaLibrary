using MultimediaLibrary.Data;
using MultimediaLibrary.Enums;
using MultimediaLibrary.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    /// <summary>
    /// Inicjowanie BD
    /// </summary>
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            // Jeżeli w BD są jakieś osoby inicjacja BD nie jest przeprowadzana
            if (context.Persons.Any())
            {
                return;   // DB została już zainicjowana
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
                new Supply{Title="Pan Tadeusz",       Author="Adam Mickiewicz",                SupplyType=SupplyType.Book,        SupplyStatus=SupplyStatus.Returned, Grade=Grade.F, Comment="Lektura"},
                new Supply{Title="Solaris",           Author="Stanislaw Lem",                  SupplyType=SupplyType.Audiobook,   SupplyStatus=SupplyStatus.Returned, Grade=Grade.A, Comment="Gruba"},
                new Supply{Title="Warsztat hakera",   Author="Matthew Hickey",                 SupplyType=SupplyType.Book,        SupplyStatus=SupplyStatus.Returned, Grade=Grade.D, Comment="Nudna"},
                new Supply{Title="The Division Bell", Author="Pink Floyd",                     SupplyType=SupplyType.CompactDisc, SupplyStatus=SupplyStatus.Returned, Grade=Grade.A},
                new Supply{Title="Grywalizacja",      Author="Paweł Tkaczyk",                  SupplyType=SupplyType.Audiobook,   SupplyStatus=SupplyStatus.Returned, Grade=Grade.B},
                new Supply{Title="Programista",       Author="Dom Wydawniczy Anna Adamczyk",   SupplyType=SupplyType.Journal,     SupplyStatus=SupplyStatus.Returned },
                new Supply{Title="Zdjęcia z wakacji", Author="Jan Kowalczyk",                  SupplyType=SupplyType.Pendrive,    SupplyStatus=SupplyStatus.Returned }
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
                new Activity{ActivityDate = DateTime.Parse("2021-02-28 16:35"),ActivityType=ActivityType.Borrowing,PersonID=8,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2022-01-18 18:25"),ActivityType=ActivityType.Borrowing,PersonID=1,SupplyID= 1},
                new Activity{ActivityDate = DateTime.Parse("2022-02-12  8:15"),ActivityType=ActivityType.Returning,PersonID=3,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2021-07-21 10:05"),ActivityType=ActivityType.Borrowing,PersonID=2,SupplyID= 4},
                new Activity{ActivityDate = DateTime.Parse("2021-03-28 12:55"),ActivityType=ActivityType.Returning,PersonID=2,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2020-07-23 13:15"),ActivityType=ActivityType.Lost,     PersonID=5,SupplyID= 5},
                new Activity{ActivityDate = DateTime.Parse("2019-04-28 16:45"),ActivityType=ActivityType.Returning,PersonID=2,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2019-07-25 22:45"),ActivityType=ActivityType.Returning,PersonID=6,SupplyID= 6},
                new Activity{ActivityDate = DateTime.Parse("2020-05-18 19:35"),ActivityType=ActivityType.Borrowing,PersonID=2,SupplyID= 7},
                new Activity{ActivityDate = DateTime.Parse("2021-11-23 20:15"),ActivityType=ActivityType.Returning,PersonID=7,SupplyID= 1},
                new Activity{ActivityDate = DateTime.Parse("2021-12-18  9:25"),ActivityType=ActivityType.Lost,     PersonID=1,SupplyID= 2},
                new Activity{ActivityDate = DateTime.Parse("2021-11-24 14:15"),ActivityType=ActivityType.Borrowing,PersonID=1,SupplyID= 2},
            };

            context.Activities.AddRange(activities);
            context.SaveChanges();
        }
    }
}
