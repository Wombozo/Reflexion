using System.ComponentModel.Design;
using NFluent;
using NUnit.Framework;

namespace Reflexion
{
    [TestFixture]
    public class FactoryTests
    {
        [Test]
        public void should_create_book()
        {
            const string className = "Book";
            const int nbPages = 300;

            var sut = Factory.Create(className, new[] {(object) nbPages});
            Check.That(sut).IsInstanceOf<Book>();
            Check.That(((Book) sut).NbPages).Equals(nbPages);
        }

        [Test]
        public void should_create_person()
        {
            const string className = "Person";
            const string name = "Ionut";
            const int nbPages = 200;
            var book = new Book() {NbPages = nbPages};

            var sut = Factory.Create(className, new[] {name, (object) book});
            Check.That(sut).IsInstanceOf<Person>();
            Check.That(((Person) sut).Name).Equals(name);
            Check.That(((Person) sut).Book.NbPages).Equals(nbPages);
        }
    }
}