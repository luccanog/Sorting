namespace Sorting.UnitTests
{
    public class SortingAlgorithmTests
    {
        [Fact]
        public void QuickSort_ShouldSucceed()
        {
            var arr = new[] { 3, 5, 2, 1, 4 };
            var alg = new QuickSort();

            var result = alg.Sort(arr);

            Assert.Equal(new[] {1,2,3,4,5}, result);
        }
    }
}