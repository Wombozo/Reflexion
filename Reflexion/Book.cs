using System.Collections.Generic;

namespace Reflexion
{
    public class Book : IModel
    {
        public int NbPages { get; set; }
        public Book()
        {
        }

        public IEnumerable<string> GetPropertiesName() => new[] {nameof(NbPages)};
    }
}