public class Solution {
    public int ThirdMax(int[] nums) {

        List<int> num = new List<int>(nums);

        for(int i = 0; i < num.Count - 1; i++)
        {
            for(int j = 0; j < num.Count - i - 1; j++)
            {
                if(num[j] < num[j+1])
                {
                    int temp = num[j];
                    num[j] = num[j+1];
                    num[j+1] = temp;
                }
                else if(num[j] == num[j+1])
                {
                    num.RemoveAt(j+1);
                    j--;
                }

            }
        }

        if(num.Count < 3) return num[0];
        else return num[2];
    }
}