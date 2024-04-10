namespace Sorting.UnitTests
{
    public class SortingAlgorithmTests
    {
        [Theory]
        [InlineData(new[] { 4, 3, 2 }, new[] { 2, 3, 4 })]
        [InlineData(new[] { 100, 50, 25 }, new[] { 25, 50, 100 })]
        [InlineData(new[] { 3, 5, 2, 1, 4 }, new[] { 1, 2, 3, 4, 5 })]
        public void QuickSort_ShouldSucceed(int[] input, int[] expectedResult)
        {
            var alg = new QuickSort();

            var result = alg.Sort(input);

            Assert.Equal(expectedResult, result);
        }

    }
}