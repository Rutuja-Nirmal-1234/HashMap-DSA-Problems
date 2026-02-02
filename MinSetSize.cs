// LeetCode 1338 - Reduce Array Size to The Half
// Approach: Frequency Map + Greedy (Sort by descending frequency)
//
// Steps:
// 1. Count frequency of each element.
// 2. Sort frequencies in descending order.
// 3. Keep removing the largest frequencies until removed elements >= n/2.
//
// Time Complexity: O(n log n)
// Space Complexity: O(n)

public class Solution {
    public int MinSetSize(int[] arr) {
        int n = arr.Length;
        int half = n / 2;

        // Frequency map
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in arr) {
            if (freq.ContainsKey(num)) {
                freq[num]++;
            } else {
                freq[num] = 1;
            }
        }

        // Sort frequencies in descending order
        List<int> freqList = freq.Values.ToList();
        freqList.Sort((a, b) => b - a);

        int removed = 0;
        int count = 0;

        // Greedily remove highest frequencies first
        foreach (int f in freqList) {
            removed += f;
            count++;
            if (removed >= half) {
                return count;
            }
        }

        return count;
    }
}
