using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);

            Assert.Equal(3, x);

            SetInt(ref x);
            Assert.Equal(42, x);
        }
        private void SetInt(ref int x) => x = 42;
        private void SetInt(int x) => x = 42;
        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(ref book1, "New Name");
            
            Assert.Equal(book1.Name, "New Name"); //Fail
            Assert.NotEqual(book1.Name, "Book1");
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");
            
            Assert.NotEqual(book1.Name, "New Name"); //Fail
            Assert.Equal(book1.Name, "Book1");
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");
            
            Assert.Equal(book1.Name, "New Name");
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal(book1.Name, "Book 1");
            Assert.Equal(book2.Name, "Book 2");
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
