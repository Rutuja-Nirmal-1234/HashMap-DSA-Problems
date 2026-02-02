// LeetCode 383 - Ransom Note
// Approach: Frequency Array (Counting)
//
// Idea:
// Count frequency of each character in magazine.
// Then check if ransomNote can be built using those characters.
//
// Time Complexity: O(n + m)
// Space Complexity: O(1)  (constant 26 size array)

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {

        int[] count = new int[26];

        // Count frequency of each character in magazine
        foreach (char ch in magazine) {
            count[ch - 'a']++;
        }

        // Try to build ransomNote
        foreach (char ch in ransomNote) {
            if (count[ch - 'a'] == 0) {
                return false;
            }
            count[ch - 'a']--;
        }

        return true;
    }
}
