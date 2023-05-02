Approach #2 (Sorting) [Accepted]
Intuition

If there are any duplicate integers, they will be consecutive after sorting.

Algorithm

This approach employs sorting algorithm. Since comparison sorting algorithm like heapsort is known to provide O(nlog⁡n)O(n \log n)O(nlogn) worst-case performance, sorting is often a good preprocessing step. After sorting, we can sweep the sorted array to find if there are any two consecutive duplicate elements.

public boolean containsDuplicate(int[] nums) {
    Arrays.sort(nums);
    for (int i = 0; i < nums.length - 1; ++i) {
        if (nums[i] == nums[i + 1]) return true;
    }
    return false;
}

Complexity Analysis

Time complexity: O(nlog⁡n)O(n \log n)O(nlogn). Sorting is O(nlog⁡n)O(n \log n)O(nlogn) and the sweeping is O(n)O(n)O(n). The entire algorithm is dominated by the sorting step, which is O(nlog⁡n)O(n \log n)O(nlogn).

Space complexity: O(1)O(1)O(1). Space depends on the sorting implementation which, usually, costs O(1)O(1)O(1) auxiliary space if heapsort is used.

Note

The implementation here modifies the original array by sorting it. In general, it is not a good practice to modify the input unless it is clear to the caller that the input will be modified. One may make a copy of nums and operate on the copy instead.