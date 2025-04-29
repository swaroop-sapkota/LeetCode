public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int n = score.Length;
        List<int> nums = new List<int>(score);
        List<string> result = new List<string>();

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (nums[j] < nums[j + 1]) {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }

        string[] rankResults = new string[n];
        
        for (int i = 0; i < n; i++) {
            if (i == 0) rankResults[i] = "Gold Medal";
            else if (i == 1) rankResults[i] = "Silver Medal";
            else if (i == 2) rankResults[i] = "Bronze Medal";
            else rankResults[i] = (i + 1).ToString();
        }

        for (int i = 0; i < n; i++) {
            int rankIndex = nums.IndexOf(score[i]);
            result.Add(rankResults[rankIndex]);
            nums[rankIndex] = -1; 
        }

        return result.ToArray();
    }
}
