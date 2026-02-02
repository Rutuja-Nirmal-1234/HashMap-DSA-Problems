// LeetCode 1338 - Reduce Array Size to The Half
// Approach: Frequency Map + Bucket Sort + Greedy
//
// Steps:
// 1. Count frequency of each number.
// 2. Build a bucket array where bucket[i] = how many numbers have frequency i.
// 3. Start removing elements with highest frequency first until removed >= n/2.
//
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public int MinSetSize(int[] arr) {

        int n = arr.Length;
        int half = n / 2;

        // Step 1: Frequency map
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in arr) {
            if (freq.ContainsKey(num)) {
                freq[num]++;
            } else {
                freq[num] = 1;
            }
        }

        // Step 2: Bucket array
        int[] bucket = new int[n + 1];
        foreach (int f in freq.Values) {
            bucket[f]++;
        }

        // Step 3: Greedy removal from highest frequency
        int removed = 0;
        int count = 0;

        for (int i = n; i >= 1 && removed < half; i--) {
            while (bucket[i] > 0 && removed < half) {
                removed += i;
                bucket[i]--;
                count++;
            }
        }

        return count;
    }
}
