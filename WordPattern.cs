// LeetCode 290 - Word Pattern
// Approach: Bidirectional HashMap Mapping
//
// Idea:
// Each character in `pattern` must map to exactly one word in `s`
// and each word must map back to exactly one character.
//
// We maintain two maps:
//   char -> string
//   string -> char
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public bool WordPattern(string pattern, string s) {

        string[] words = s.Split(' ');
        if (words.Length != pattern.Length) return false;

        Dictionary<char, string> map1 = new Dictionary<char, string>();   // pattern -> word
        Dictionary<string, char> map2 = new Dictionary<string, char>();   // word -> pattern

        for (int i = 0; i < pattern.Length; i++) {

            char ch = pattern[i];
            string word = words[i];

            if (map1.ContainsKey(ch)) {
                if (map1[ch] != word) return false;
            } else {
                map1[ch] = word;
            }

            if (map2.ContainsKey(word)) {
                if (map2[word] != ch) return false;
            } else {
                map2[word] = ch;
            }
        }

        return true;
    }
}
