// LeetCode 2215 - Find the Difference of Two Arrays
// Approach: Use HashSets to find unique elements in nums1 not in nums2 and vice versa.
//
// Time Complexity: O(n + m) where n and m are lengths of nums1 and nums2
// Space Complexity: O(n + m) for hash sets and result lists

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);

        List<int> res1 = new List<int>();
        List<int> res2 = new List<int>();

        foreach (int num in set1) {
            if (!set2.Contains(num)) {
                res1.Add(num);
            }
        }
        foreach (int num in set2) {
            if (!set1.Contains(num)) {
                res2.Add(num);
            }
        }

        return new List<IList<int>> { res1, res2 };
    }
}
