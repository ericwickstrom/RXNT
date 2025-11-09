using FluentAssertions;
using Xunit;

namespace CactusClinic.Domain.Tests
{
    public class DomainSetupTests
    {
        [Fact]
        public void Domain_Tests_Setup_Should_Work()
        {
            // Arrange
            var expected = true;
            
            // Act
            var actual = true;
            
            // Assert
            actual.Should().Be(expected);
        }
    }
}
