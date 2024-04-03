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
            return Sort(nums, 0, nums.Length);
        }

        private int[] Sort(int[] nums, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(nums, start, end);

                Sort(nums, start, pivot);
                Sort(nums, pivot + 1, end);
            }

            return nums;
        }

        private int Partition(int[] nums, int start, int end)
        {
            int pivot = nums[start];
            int swapIndex = start;

            for (int i = start + 1; i < end; i++)
            {
                if (nums[i] < pivot)
                {
                    swapIndex++;
                    Swap(nums, i, swapIndex);
                }
            }
            Swap(nums, start, swapIndex);
            return swapIndex;
        }

        private static void Swap(int[] nums, int left, int right)
        {
            int aux = nums[left];
            nums[left] = nums[right];
            nums[right] = aux;
        }
    }
}
