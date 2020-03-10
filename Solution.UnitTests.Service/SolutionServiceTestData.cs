using System;
using System.Collections.Generic;
using System.Collections;

namespace Solution.UnitTests.Service
{

    public class SolutionServiceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { -1, 0  };
            yield return new object[] { 10, 11 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}