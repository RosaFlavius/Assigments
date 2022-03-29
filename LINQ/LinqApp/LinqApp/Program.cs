using LinqApp;
using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {


            foreach (var number in items)
            {
                if (predicate(number))
                {
                    yield return number;
                }
            }

        }

        public static IEnumerable<string> FilterString(this IEnumerable<string> items, Func<string, bool> predicate)
        {


            foreach (var name in items)
            {
                if (predicate(name))
                {
                    yield return name;
                }
            }

        }

        public static IEnumerable<int> NumbersSmallerThan7(this IEnumerable<int> items)
        {
            int number = 0;
            while (number < 7)
            {
                number++;
                yield return number;
            }

        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {

            Filtering();
            Ordering();
            Projection();
            Quantifiers();
            Grouping();
            Joins();
            SetOperations();
            Agreggations();
            Element();
            Conversion();
            Generation();

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] strings = new string[] { "apple", "banana", "orange", "watermelon" };
            
            var predicate = numbers
                .Filter(number => number % 2 == 0)
                .Filter(number => number >5);

            var predicate1 = strings
                .FilterString(stringss=>stringss.Length>5);
            // .Filter(stringss => number > 5);

            var numbersCollection = numbers.NumbersSmallerThan7();


            
        }
        
        
        



            public static void Filtering()
        {
            //Where
            var countriesWithMoreThan20Towns = _countries.Where(country => country.HasMoreThan20Towns);

            //Take
            var takeFirstThree = _countries.Take(3);

            //TakeWhile
            var takeANumberOfCountries = _countries.TakeWhile(country => country.NumberOfInhabitants > 10000000);

            //Skip
            var allButFirstThree = _countries.Skip(3);

            //SkipWhile
            var skipANumberOfCountries = _countries.SkipWhile(country => country.NumberOfInhabitants > 40000000);

            //Distinct
            var distinctCountries = _countries.Distinct();


            //Chunk
            var chunkedResult = _countries.Chunk(3);

            
        }

        public static void Ordering()
        {
            //OrderBy, ThenBy
            var orderedAscending = _countries.OrderBy(country => country.Name).ThenBy(country => country.NumberOfInhabitants);

            //OrderByDescending, ThenByDescending
            var orderedDescending = _countries.OrderByDescending(country => country.Name).ThenByDescending(country => country.NumberOfInhabitants);

            //Reverse
            var reverseList = _countries.Reverse();

        }

        public static void Quantifiers()
        {
            //Any
            var atLeastOne = _countries.Any(country => country.Id == "1");

            //All
            var allCountriesHaveSpecificId = _countries.All(country => country.Id == "1");

            //Contatins
            var contained = _countries.Contains(_countries.ElementAt(2));

            //SequenceEqual
            var SE = _countries.SequenceEqual(_countries);
        }

        public static void Projection()
        {

            //Select
            var squareIntList = _listOfObjects.OfType<int>().Select(x => x * x);

            //Select Many
            var selectMultiple = _countries.SelectMany(country => country.hasTown);
        }

        public static void Grouping()
        {
            //GroupBy
            var grupedByNoI = _towns.GroupBy(town => town.NumberOfInhabitants);
        }

        public static void Joins()
        {
            //Join
            var TownsByCountries = _countries.Join(
                _towns,
                country => country.Id,
                town => town.Id,
                (country, town) => new { country.Name, town.NumberOfInstitutions }
                );

            //GroupJoin

            var TownsByCountriesGJ = _countries.Join(
                _towns,
                country => country.Id,
                town => town.Id,
                (country, town) => new { country.Name, town.NumberOfInstitutions }
                );

            //Zip
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

        }

        public static void SetOperations()
        {
            

            //Except
            var exceptBySomeCountries = _countries.Except(_countries.Where(country => country.HasMoreThan20Towns));

            //Intersect
            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };

            var intersect = id1.Intersect(id2);

            //Union, UnionBy(distinct union)
            var uni = _countries.Select(country => country.NumberOfInhabitants).Union(_towns.Select(town => town.NumberOfInstitutions));

            //Concat(non distinct)
            var query = _countries.Select(country => country.Name).Concat(_towns.Select(town => town.Name));
        }

        public static void Agreggations()
        {
            //Count, LongCount
            var countNoI = _countries.Count();
            var countNoI1= _countries.LongCount();
            //Min, Max
            var minNoITown = _towns.Min(town => town.NumberOfInstitutions);
            var maxNoITown = _towns.Max(town => town.NumberOfInstitutions);
            //Sum, Avarage
            var sumNoITowns= _towns.Sum(town => town.NumberOfInstitutions);
            var avarageNoITowns = _towns.Average(town => town.NumberOfInstitutions);
        }

        public static void Element()
        {
            int[] v = { };
            //First, FirstOrDefault
            var first = _countries.First();
            var firstOrDefault = v.FirstOrDefault();
            //Last, LastOrDefault
            var last = _countries.Last();
            var lastOrDefault = v.LastOrDefault();
            //Single, SingleOrDefault
            /* var single = _countries.Single();
             var singleOrDefault = _countries.SingleOrDefault();*/

            //ElementAt, ElementAtOrDefault
            var elementAtt = _countries.ElementAt(2);
            var elementAtOrDefault = _countries.ElementAtOrDefault(21);
            //DefaultEmpty
            var defaultEmpty = v.DefaultIfEmpty();
        }

        public static void Conversion()
        {
            //OfType
            var intList = _listOfObjects.OfType<int>();

            //Cast
            var cast = _countries.Cast<Country>();

            //ToArray
            var array = _countries.ToArray();

            //ToList
            int[] arr = { 44, 26, 92, 30, 71, 38 };
            var arrToList = arr.ToList();

            //ToDictionary

            //Dictionary<int, Country> dictionary = _countries.ToDictionary(country=>country.NumberOfInhabitants);
            //ToLookup
            ILookup<char, string> lookup =_countries.ToLookup(country => country.Name[0],
                                                              country => country.Name + " " + country.NumberOfInhabitants);
            //AsEnumerable
            arr.AsEnumerable();

            //AsQueryable
            IQueryable<Country> iqeuryable = _countries.AsQueryable();
        }

        public static void Generation()
        {
            //Empty
            var empty = Enumerable.Empty<int>();
            //Repeat
            IEnumerable<string> strings = Enumerable.Repeat("repeat", 5);
            //Range
            IEnumerable<int> ints = Enumerable.Range(1, 10);
        }

        


        private static readonly IEnumerable<Country> _countries = CreateCountriesList();
        private static IEnumerable<Country> CreateCountriesList()
        {
            return new List<Country>
            {
                new Country { Id = "1" , Name="Romania", NumberOfInhabitants=19237691, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } } },
                new Country { Id = "2" , Name="Poland", NumberOfInhabitants=37846611, HasMoreThan20Towns=false,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } } },
                new Country { Id = "3" , Name="France", NumberOfInhabitants=65273511, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } } },
                new Country { Id = "3" , Name="France", NumberOfInhabitants=65273511, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "4" , Name="Germany", NumberOfInhabitants=83783942, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "5" , Name="Spain", NumberOfInhabitants=46754778, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "6" , Name="Ukraine", NumberOfInhabitants=43733762, HasMoreThan20Towns=false,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "7" , Name="UnitedKindom", NumberOfInhabitants=67886011, HasMoreThan20Towns=false,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "8" , Name="Netherlands", NumberOfInhabitants=17134872, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "8" , Name="Netherlands", NumberOfInhabitants=17134872, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "9" , Name="Italy", NumberOfInhabitants=60461826, HasMoreThan20Towns=true,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},
                new Country { Id = "10" , Name="Russia", NumberOfInhabitants=145934462, HasMoreThan20Towns=false,  hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } }},

                new Country { Id = "3" , Name="France", NumberOfInhabitants=65273511, HasMoreThan20Towns=true,
                hasTown= new List<Town> {
                    new Town(){ Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003}, 
                    new Town { Id = "1", Name = "Cluj-Napoca", NumberOfInhabitants = 316748, NumberOfInstitutions = 100000 } } },
                

            };
        }

        private static readonly IEnumerable<Town> _towns = CreateTownsList();
        private static IEnumerable<Town> CreateTownsList()
        {
            return new List<Town>
            {
                new Town { Id = "1" , Name="Cluj-Napoca", NumberOfInhabitants=316748, NumberOfInstitutions=100000},
                new Town { Id = "1" , Name="Cluj-Napoca", NumberOfInhabitants=316748, NumberOfInstitutions=100001},
                new Town { Id = "2" , Name="Berlin", NumberOfInhabitants=316748, NumberOfInstitutions=100002},
                new Town { Id = "3" , Name="Paris", NumberOfInhabitants=316748, NumberOfInstitutions=100003},
                new Town { Id = "4" , Name="London", NumberOfInhabitants=316748, NumberOfInstitutions=100004},
                new Town { Id = "5" , Name="Barcelona", NumberOfInhabitants=316748, NumberOfInstitutions=100005},
                new Town { Id = "6" , Name="Madrid", NumberOfInhabitants=316748, NumberOfInstitutions=100006},
                new Town { Id = "7" , Name="Arad", NumberOfInhabitants=316748, NumberOfInstitutions=100007},
                new Town { Id = "8" , Name="Frankfurt", NumberOfInhabitants=316748, NumberOfInstitutions=100008},
                new Town { Id = "9" , Name="Birmingham", NumberOfInhabitants=316748, NumberOfInstitutions=100009},
                new Town { Id = "10" , Name="Bucuresti", NumberOfInhabitants=316748, NumberOfInstitutions=100010},


                new Town { Id = "11" , Name="ForGroupedBy", NumberOfInhabitants=1, NumberOfInstitutions=100000},
                new Town { Id = "12" , Name="ForGrupedBy2", NumberOfInhabitants=1, NumberOfInstitutions=100000},
            };
        }

      
        private static readonly IEnumerable<object> _listOfObjects = CreateStringsList();

        private static IEnumerable<object> CreateStringsList()
        {
            return new List<object>
            {
                "Ball", "Mouse", "Laptop", 12 ,14, 16
            };
        }

       



    }
}