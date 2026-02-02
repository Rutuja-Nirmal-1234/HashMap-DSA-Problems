// LeetCode 451 - Sort Characters By Frequency
// Approach: Count frequency of each character, use bucket sort where
// each bucket index represents frequency, then build the result string
// starting from the highest frequency bucket.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Count frequency of each character
        foreach(char ch in s) {
            if(freq.ContainsKey(ch)) {
                freq[ch]++;
            } else {
                freq[ch] = 1;
            }
        }

        // Create buckets where index is frequency
        List<char>[] bucket = new List<char>[s.Length + 1];
        foreach(var pair in freq) {
            int count = pair.Value;
            if(bucket[count] == null) {
                bucket[count] = new List<char>();
            }
            bucket[count].Add(pair.Key);
        }

        StringBuilder sb = new StringBuilder();

        // Build string from high frequency to low
        for(int i = bucket.Length - 1; i >= 0; i--) {
            if(bucket[i] != null) {
                foreach(char ch in bucket[i]) {
                    sb.Append(new string(ch, i));
                }
            }
        }
        return sb.ToString();
    }
}
