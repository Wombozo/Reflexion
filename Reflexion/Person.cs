using System.Collections.Generic;

namespace Reflexion
{
    public class Person : IModel
    {
        public string Name { get; set; }
        public Book Book { get; set; }

        public Person()
        {
        }

        public IEnumerable<string> GetPropertiesName() => new []{nameof(Name), nameof(Book)};
    }
}