// LeetCode 771 - Jewels and Stones
// Approach: HashSet
//
// Idea:
// Store all jewel characters in a HashSet.
// Then iterate over stones and count those present in the set.
//
// Time Complexity: O(n + m)
// Space Complexity: O(n)

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {

        HashSet<char> set = new HashSet<char>();

        // Store all jewels
        foreach (char ch in jewels) {
            set.Add(ch);
        }

        int count = 0;

        // Count stones that are jewels
        foreach (char ch in stones) {
            if (set.Contains(ch)) {
                count++;
            }
        }

        return count;
    }
}
