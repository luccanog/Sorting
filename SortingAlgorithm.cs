namespace Sorting
{
    public abstract class SortingAlgorithm
    {
        public abstract int[] Sort(int[] nums);
    }

    public class MergeSort : SortingAlgorithm
    {
        public override int[] Sort(int[] nums)
        {
            throw new NotImplementedException();
        }
    }

    public class QuickSort : SortingAlgorithm
    {
        public override int[] Sort(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }

            if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                {
                    return new int[2] { nums[1], nums[0] };
                }

                return nums;
            }

            var pivot = nums[0];
            var lower = new List<int>();
            var greater = new List<int>();


            for (int i = 1; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num > pivot)
                {
                    greater.Add(num);
                }
                else
                {
                    lower.Add(num);
                }
            }

            var lowerSorted = Sort(lower.ToArray());
            var greaterSorted = Sort(greater.ToArray());

            return lowerSorted.Append(pivot).Concat(greaterSorted).ToArray();
        }
    }
}
