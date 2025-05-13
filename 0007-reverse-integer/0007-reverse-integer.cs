public class Solution {
    public int Reverse(int x) {
        int rev = 0;

        while (x != 0) {
            int rem = x % 10;

            if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && rem > 7)) {
                return 0;
            }
            if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && rem < -8)) {
                return 0;
            }

            rev = rev * 10 + rem;
            x /= 10;
        }

        return rev;
    }
}
