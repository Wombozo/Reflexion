using System.Collections.Generic;

namespace Reflexion
{
    public interface IModel
    {
        IEnumerable<string> GetPropertiesName();
    }

    public class Book : IModel
    {
        public int NbPages { get; set; }

        public Book()
        {
        }

        public IEnumerable<string> GetPropertiesName() => new[] {nameof(NbPages)};
    }

    public class Person : IModel
    {
        public string Name { get; set; }
        public Book Book { get; set; }

        public Person()
        {
        }

        public IEnumerable<string> GetPropertiesName() => new[] {nameof(Name), nameof(Book)};
    }
}