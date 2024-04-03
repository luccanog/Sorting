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
            return Sort(nums, 0, nums.Length - 1);
        }

        private int[] Sort(int[] nums, int leftIndex, int rightIndex)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }

            int pivot = nums[leftIndex], left = leftIndex, right = rightIndex;

            while (left <= right)
            {

                while (nums[left] < pivot)
                {
                    left++;
                }

                while (nums[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    Swap(nums, left, right);
                    left++;
                    right--;
                }
            }

            if (leftIndex < right)
            {
                Sort(nums, leftIndex, right);
            }
            if (left < rightIndex)
            {
                Sort(nums, left, rightIndex);
            }

            return nums;
        }

        private static void Swap(int[] nums, int left, int right)
        {
            int aux = nums[left];
            nums[left] = nums[right];
            nums[right] = aux;
        }
    }
}
