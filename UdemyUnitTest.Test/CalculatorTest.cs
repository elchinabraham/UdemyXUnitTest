using UdemyUnitTest.App;

namespace UdemyUnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            int a = 5, b = 20;
            var calculator = new Calculator();

            // Act
            var total = calculator.Add(a, b);

            // Assert
            Assert.Equal(25, total);
        } 

        [Fact]
        public void TestContains()
        {
            // Assert.DoesNotContain("Elcin", "Elcin Ibrahimli");

            var names = new List<string> { "Elcin", "Feteli", "Fuad" };

            Assert.Contains(names, x => x == "Elcin");
        } 

        [Fact]
        public void TestTrueFalse()
        {
            Assert.False(4 < 3);
        } 

        [Fact]
        public void TestMatch()
        {
            var regEx = "^dog";

            Assert.Matches(regEx, "dog animal");
        } 

        [Fact]
        public void TestStartEndWith()
        {
            Assert.StartsWith("Bir", "Bir masal");
        } 

        [Fact]
        public void TestEmptyNotEmpty()
        {
            Assert.NotEmpty(new List<string> { "1", "2", "3" });

            Assert.Empty(new List<string>());
        } 

        [Fact]
        public void TestRangeNotInRange()
        {
            Assert.InRange(10, 2, 20);
        }

        [Fact]
        public void TestSingle()
        {
            Assert.Single(new List<string> { "1" });

            //Assert.Single<int>(new List<int> { 2, 3 });
        }

        [Fact]
        public void TestIsType()
        {
            Assert.IsNotType<int>("Test");
        }

        [Fact]
        public void TestIsAssignableForm()
        {
            Assert.IsAssignableFrom<IEnumerable<string>>(new List<string> {  });

            Assert.IsAssignableFrom<object>(new Random());
        }

        [Fact]
        public void TestNullNotNull()
        {
            string text = null;
            Assert.Null(text);

            string name = "Elcin";
            Assert.NotNull(name);
        }

        [Fact]
        public void TestEqualNotEqual()
        {
            int number = 12;

            Assert.Equal(12, number);

            var dt = new DateTime(2024, 12, 05);
            var date = DateTime.Now;

            Assert.NotEqual(date, dt);
        }
    }
}
