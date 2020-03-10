using System;
using Xunit;
using Solution.Service;
using System.Collections.Generic;
using System.Collections;

namespace Solution.UnitTests.Service
{
    public class SolutionServiceTests
    {
        private readonly SolutionService _solutionService;

        public SolutionServiceTests()
        {
            _solutionService = new SolutionService();
        }

        [Theory]
        //[ClassData(typeof(SolutionServiceTestData))]
        [InlineData(0, 1)]
        public void Should_Increment_By_1(int parameter, int expected)
        {
            var actual = _solutionService.increment(parameter);

            Assert.Equal(actual, expected);
        }
    }
}
