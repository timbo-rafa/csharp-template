using System;
using System.Collections.Generic;

namespace Solution.Service
{
    public class SolutionService : ISolutionService
    {

        public int increment(int parameter)
        {
            return parameter + 1;
        }
    }
}
