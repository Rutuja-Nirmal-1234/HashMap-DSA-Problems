// LeetCode 2006 - Count Number of Pairs With Absolute Difference K
// Approach: Use a dictionary to keep track of frequency of elements seen so far,
// and for each number, check if (num - k) or (num + k) exists in the map to count pairs.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public int CountKDifference(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int count = 0;

        foreach (int num in nums) {
            if (map.ContainsKey(num - k)) {
                count += map[num - k];
            }
            if (map.ContainsKey(num + k)) {
                count += map[num + k];
            }

            if (map.ContainsKey(num)) {
                map[num]++;
            } else {
                map[num] = 1;
            }
        }
        return count;
    }
}
