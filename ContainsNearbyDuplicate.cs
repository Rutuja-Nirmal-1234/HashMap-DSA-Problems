// LeetCode 219 - Contains Duplicate II
// https://leetcode.com/problems/contains-duplicate-ii/

// Approach: HashMap (Dictionary)
//
// Idea:
// Store the last index of each number.
// If the same number appears again, check the index difference.
// If (currentIndex - lastIndex) <= k → return true.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {

            if (map.ContainsKey(nums[i])) {
                int lastIndex = map[nums[i]];
                if (i - lastIndex <= k) {
                    return true;
                }
            }

            // Always update with latest index
            map[nums[i]] = i;
        }

        return false;
    }
}
