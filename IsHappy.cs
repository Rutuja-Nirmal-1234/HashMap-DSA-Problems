// LeetCode 202 - Happy Number
// Approach: Floyd’s Cycle Detection (Fast & Slow Pointers)
//
// Idea:
// Repeatedly replace the number with the sum of squares of its digits.
// If the process ends in 1 → Happy Number.
// If a cycle occurs that doesn't include 1 → Not Happy.
//
// Use fast & slow pointers to detect cycle efficiently.
//
// Time Complexity: O(log n)
// Space Complexity: O(1)

public class Solution {
    public bool IsHappy(int n) {

        int slow = n;
        int fast = n;

        do {
            slow = Next(slow);          // move 1 step
            fast = Next(Next(fast));   // move 2 steps
        } while (slow != fast);

        return slow == 1;
    }

    private int Next(int n) {
        int sum = 0;

        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}
