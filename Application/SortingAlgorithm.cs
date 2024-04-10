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

        /// <summary>
        /// Sort the array recursively
        /// </summary>
        /// <param name="nums">The input array</param>
        /// <param name="start">The operation start index</param>
        /// <param name="end">The operation final index</param>
        /// <returns></returns>
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

        // The Partition method is basically going to use the first element as a pivot
        // transverse the input array from left to right and move each value lower than the pivot
        // to the next available left position. (the next available left position is setted by the swapIndex variable.
        // After moving every lower values to the left, the first element(aka pivot) is placed right after them, and then we return it.
        private int Partition(int[] nums, int start, int end)
        {
            // the pivot is going to be the first element.
            // we are going to use it as reference, moving the lower values to the left
            // and the greater values to the right
            var pivot = nums[start];

            // the swapIndex is a pointer which tells where can we place the found lower value
            // it is initialized with the 'start' value and then on each swap it is going to be increased
            var swapIndex = start;

            // we are going to transverse the input array from left to the right
            // the iterator is going to be initialized with 'start +1' in order to skip the pivot value
            for (int i = start + 1; i < end; i++)
            {
                // if the current value is lower or equals the pivot, we are going to send it to the left
                // NOTE: the values are going to the left because the swapIndex initial value is the start
                if (nums[i] <= pivot)
                {
                    swapIndex++;
                    Swap(nums, i, swapIndex);
                }
            }
            
            // after transversing the entire array, we are going to place the pivot next to each moved value
            // so we swap it with the last moved value, so every value on it's left is going to be lower than it
            Swap(nums, start, swapIndex);

            // now, the swapIndex means both the amount of changes made and the current index of the pivot
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
