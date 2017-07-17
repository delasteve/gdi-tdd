using System;
using FluentAssertions;
using Xunit;

namespace GdiTdd.Tests
{
    public class FooTest
    {
        [Fact]
        public void Should_Pass()
        {
            false.Should().Be(true); // purposely failing
        }
    }
}
