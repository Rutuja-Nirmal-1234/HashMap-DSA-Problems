// LeetCode 242 - Valid Anagram
// Approach: Frequency Counting using Array
//
// Idea:
// 1. Remove spaces and normalize case.
// 2. If lengths differ → not anagram.
// 3. Use int[26] to store frequency.
//    - Increment for s
//    - Decrement for t
// 4. If any index != 0 → not anagram
//
// Time Complexity: O(n)
// Space Complexity: O(1)   (fixed size array of 26)

public class Solution {
    public bool IsAnagram(string s, string t) {

        s = s.Replace(" ", "").ToLower();
        t = t.Replace(" ", "").ToLower();

        if (s.Length != t.Length) return false;

        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int num in count) {
            if (num != 0) return false;
        }

        return true;
    }
}
