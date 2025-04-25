public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num < 0) return false;

        int left = 0, right = num / 2 + 1; // Bound right to sqrt(num)

        while (left <= right) {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;  // To avoid overflow for large numbers

            if (square == num) {
                return true;
            } else if (square < num) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return false;
    }
}
