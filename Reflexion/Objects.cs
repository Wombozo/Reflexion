using System.Collections.Generic;

namespace Reflexion
{
    [ModelObject("It's a book")]
    public class Book
    {
        public int NbPages { get; set; }

        public Book()
        {
        }

        public IEnumerable<string> GetPropertiesName() => new[] {nameof(NbPages)};
    }

    [ModelObject("It's a Person")]
    public class Person
    {
        public string Name { get; set; }
        public Book Book { get; set; }

        public Person()
        {
        }

        public IEnumerable<string> GetPropertiesName() => new[] {nameof(Name), nameof(Book)};
    }
}