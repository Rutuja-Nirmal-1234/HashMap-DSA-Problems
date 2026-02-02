// LeetCode 205 - Isomorphic Strings
// Approach: Bidirectional HashMap Mapping
//
// Idea:
// Two strings s and t are isomorphic if:
// - Every character in s maps to exactly one character in t
// - And every character in t maps back to exactly one character in s
//
// So we maintain two maps:
//   s -> t  and  t -> s
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public bool IsIsomorphic(string s, string t) {

        if (s.Length != t.Length) return false;

        Dictionary<char, char> map1 = new Dictionary<char, char>(); // s -> t
        Dictionary<char, char> map2 = new Dictionary<char, char>(); // t -> s

        for (int i = 0; i < s.Length; i++) {

            char c1 = s[i];
            char c2 = t[i];

            if (map1.ContainsKey(c1)) {
                if (map1[c1] != c2) return false;
            } else {
                map1[c1] = c2;
            }

            if (map2.ContainsKey(c2)) {
                if (map2[c2] != c1) return false;
            } else {
                map2[c2] = c1;
            }
        }

        return true;
    }
}
