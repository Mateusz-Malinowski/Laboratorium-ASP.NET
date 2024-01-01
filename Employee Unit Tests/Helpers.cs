using Microsoft.EntityFrameworkCore;
using Moq;

namespace Employee_Unit_Tests
{
    public class Helpers
    {
        public static Mock<DbSet<T>> CreateDbSetMock<T>(List<T> elements, string primaryKeyField) where T : class
        {
            var elementsAsQueryable = elements.AsQueryable();
            var dbSetMock = new Mock<DbSet<T>>();

            dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(elementsAsQueryable.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(elementsAsQueryable.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(elementsAsQueryable.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(elementsAsQueryable.GetEnumerator());
            dbSetMock.Setup(m => m.Find(It.IsAny<object[]>())).Returns<object[]>(input => elements.FirstOrDefault(
                element => (int)element.GetType().GetProperty(primaryKeyField).GetValue(element) == (int)input.First()));
            dbSetMock.Setup(m => m.Add(It.IsAny<T>())).Callback<T>(input => elements.Add(input));
            dbSetMock.Setup(m => m.Update(It.IsAny<T>())).Callback<T>(input =>
            {
                var index = elements.FindIndex(element => (int)element.GetType().GetProperty(primaryKeyField).GetValue(element) ==
                    (int)input.GetType().GetProperty(primaryKeyField).GetValue(input));
                elements[index] = input;
            });
            dbSetMock.Setup(m => m.Remove(It.IsAny<T>())).Callback<T>(input => elements.Remove(input));

            return dbSetMock;
        }
    }
}
