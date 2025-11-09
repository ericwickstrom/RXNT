using FluentAssertions;
using Moq;
using Xunit;

namespace CactusClinic.Application.Tests
{
    public class ApplicationSetupTests
    {
        [Fact]
        public void Application_Tests_Setup_Should_Work()
        {
            // Arrange
            var mockService = new Mock<object>();
            var expected = "Setup Complete";
            
            // Act
            var actual = "Setup Complete";
            
            // Assert
            actual.Should().Be(expected);
            mockService.Should().NotBeNull();
        }
        
        [Fact]
        public void FluentAssertions_Should_Work()
        {
            // Arrange & Act
            var numbers = new[] { 1, 2, 3, 4, 5 };
            
            // Assert
            numbers.Should().HaveCount(5)
                   .And.Contain(3)
                   .And.NotContain(0);
        }
    }
}
