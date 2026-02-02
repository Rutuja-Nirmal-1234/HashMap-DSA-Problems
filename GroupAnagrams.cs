// LeetCode 49 - Group Anagrams
// Approach: Sorting + HashMap
//
// Idea:
// 1. For each string → sort characters.
// 2. Sorted string becomes the key.
// 3. All anagrams produce the same sorted key.
// 4. Group them using Dictionary<key, List<string>>.
//
// Time Complexity: O(n * k log k)
// Space Complexity: O(n * k)
//
// Where:
// n = number of strings
// k = average length of each string

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string s in strs) {

            char[] arr = s.ToCharArray();
            Array.Sort(arr);                 // O(k log k)
            string key = new string(arr);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(s);
        }

        return new List<IList<string>>(map.Values);
    }
}
