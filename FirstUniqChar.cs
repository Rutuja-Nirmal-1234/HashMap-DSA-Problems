// LeetCode 387 - First Unique Character in a String
// Approach: Frequency HashMap + Linear Scan
//
// Idea:
// 1. Count frequency of each character.
// 2. Traverse string again → first char with frequency = 1 → answer.
//
// Time Complexity: O(n)
// Space Complexity: O(1)  [because only 26 lowercase letters]

public class Solution {
    public int FirstUniqChar(string s) {

        Dictionary<char, int> dict = new Dictionary<char, int>();

        // Step 1: Count frequency
        foreach (char ch in s) {
            if (dict.ContainsKey(ch)) {
                dict[ch]++;
            } else {
                dict[ch] = 1;
            }
        }

        // Step 2: Find first unique character
        for (int i = 0; i < s.Length; i++) {
            if (dict[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}
