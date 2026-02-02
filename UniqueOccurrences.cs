// LeetCode 1207 - Unique Number of Occurrences
// Approach: Count occurrences of each number, then check if all counts are unique.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        // Count frequency of each number
        foreach(int num in arr) {
            if(dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }

        // Check if frequencies are unique using a HashSet
        HashSet<int> set = new HashSet<int>();
        foreach(int count in dict.Values) {
            if(set.Contains(count)) {
                return false;
            }
            set.Add(count);
        }

        return true;
    }
}
