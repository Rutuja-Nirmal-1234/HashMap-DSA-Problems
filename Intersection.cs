// LeetCode 349 - Intersection of Two Arrays
// Approach: HashSet
//
// Idea:
// 1. Store all elements of nums1 in a HashSet.
// 2. Traverse nums2 → if element exists in set1 → add to result set.
// 3. Convert result set to array.
//
// Time Complexity: O(n + m)
// Space Complexity: O(n)

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> result = new HashSet<int>();

        foreach (int num in nums2) {
            if (set1.Contains(num)) {
                result.Add(num);
            }
        }

        return result.ToArray();
    }
}
