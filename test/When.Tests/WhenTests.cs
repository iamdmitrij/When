using AutoFixture.Xunit2;
using FluentAssertions;
using System;
using Xunit;

namespace When.Tests
{
    public class WhenTests
    {
        [Theory, AutoData]
        public void Tomorrow_FromToday_ShouldReturnTomorrow(DateTime origin)
        {
            // Arrange
            var expected = origin.AddDays(1);
            // Act
            var actual = expected.Tomorrow();
            // Assert
            actual.Should().BeOnOrAfter(expected);
        }

        [Theory, AutoData]
        public void Yesterday_FromToday_ShouldReturnYesterday(DateTime origin)
        {
            // Arrange
            var expected = origin.AddDays(-1);
            // Act
            var actual = expected.Yesterday();
            // Assert
            actual.Should().BeOnOrBefore(expected);
        }
    }
}
