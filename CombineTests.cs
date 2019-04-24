using System;
using Xunit;

namespace combine
{
    public class CombineTests
    {
        string people = 
@"1,Sally
2,John
3,Cortana";

        string colors =
@"2,Green
3,Blue
4,Red";

        string expected =
@"2,John,Green
3,Cortana,Blue";

        [Fact]
        public void CombineLists()
        {
            var result = "";
            Assert.Equal(expected, result);
        }
    }
}
