// LeetCode 560 - Subarray Sum Equals K
// Approach: Prefix Sum + HashMap
//
// Idea:
// If prefixSum[j] - prefixSum[i] = k,
// then subarray (i+1 ... j) has sum = k.
//
// We store frequency of prefix sums seen so far.
// For each new prefix sum `sum`, we check if (sum - k) exists.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public int SubarraySum(int[] nums, int k) {

        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = 1;   // base case: prefix sum = 0 occurs once

        int sum = 0;
        int count = 0;

        foreach (int num in nums) {
            sum += num;

            if (map.ContainsKey(sum - k)) {
                count += map[sum - k];
            }

            if (!map.ContainsKey(sum)) {
                map[sum] = 0;
            }
            map[sum]++;
        }

        return count;
    }
}
