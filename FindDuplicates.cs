// LeetCode 442 - Find All Duplicates in an Array
// Approach: HashMap Frequency Counting
//
// Idea:
// Count occurrences of each number.
// When frequency becomes 2, add it to result.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 0;
            }

            map[num]++;

            if (map[num] == 2) {
                result.Add(num);
            }
        }

        return result;
    }
}
