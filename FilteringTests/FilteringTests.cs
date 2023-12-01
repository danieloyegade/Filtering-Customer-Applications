using FilteringCustomerApplications;
using FluentAssertions;
using NUnit.Framework;

namespace FilteringTests
{
    [TestFixture]
    public class ApplicationFilterTests
    {
        private ApplicationFilter filter;


        [SetUp]
        public void SetUp()
        {
            filter = new ApplicationFilter();
        }

        [TestCase(25, true)]
        [TestCase(18, false)]
        [TestCase(81, false)]
        public void IsValidAge(int age, bool expectedResult)
        {
            // Arrange
            var application = new CarFinanceApplication { Age = age };

            // Act
            var result = filter.IsValidAge(application);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestCase(CreditBanding.C, true)]
        [TestCase(CreditBanding.A, false)]
        public void IsValidCreditBanding(CreditBanding creditBanding, bool expectedResult)
        {
            // Arrange
            var application = new CarFinanceApplication { CreditBanding = creditBanding };

            // Act
            var result = filter.IsValidCreditBanding(application);

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestCase("Engineer", true)]
        [TestCase("Driver", false)]
        public void IsValidOccupation(string occupation, bool expectedResult)
        {
            // Arrange
            var application = new CarFinanceApplication { Occupation = occupation };

            // Act
            var result = filter.IsValidOccupation(application);

            // Assert
            result.Should().Be(expectedResult);
        }
        
    }
}
