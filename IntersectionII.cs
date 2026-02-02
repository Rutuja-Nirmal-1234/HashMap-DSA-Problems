// LeetCode 350 - Intersection of Two Arrays II
// Approach: HashMap / Frequency Counter
//
// Idea:
// 1. Store frequency of each number from nums1 in a dictionary.
// 2. Traverse nums2 → if number exists and freq > 0 → add to result.
// 3. Decrease frequency to maintain correct count.
//
// Time Complexity: O(n + m)
// Space Complexity: O(n)

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {

        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> result = new List<int>();

        // Count frequency of nums1
        foreach (int num in nums1) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }

        // Match with nums2
        foreach (int num in nums2) {
            if (dict.ContainsKey(num) && dict[num] > 0) {
                result.Add(num);
                dict[num]--;
            }
        }

        return result.ToArray();
    }
}
