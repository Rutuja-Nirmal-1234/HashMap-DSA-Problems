// LeetCode 1 - Two Sum
// https://leetcode.com/problems/two-sum/

// Approach: HashMap (Dictionary)
//
// Idea:
// While traversing the array, store each number with its index.
// For current number nums[i], check if (target - nums[i]) already exists.
// If yes → found the pair.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}
