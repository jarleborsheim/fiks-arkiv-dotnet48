using System;

namespace TestLib
{
    public class ShouldFail
    {
        public void AlwaysFailWithAggregateException()
        {
            throw new AggregateException("Always this exception");
        }
    }
}