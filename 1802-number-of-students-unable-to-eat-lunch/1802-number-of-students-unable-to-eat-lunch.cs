public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int n = students.Length;
        int studentIndex = 0; // front of queue
        int sandwichesIndex = 0; // top of sandwiches stack
        int count = 0; // no of students not taking the sandwich

        while(count < n)
        {
            if(students[studentIndex] == sandwiches[sandwichesIndex])
            {
                sandwichesIndex++;

                for(int i = studentIndex; i < n - 1; i++)
                {
                    students[i] = students[i+1];
                }

                n--;
                count = 0;

            }
            else
            {
                int temp = students[studentIndex];
                for(int i = studentIndex; i < n - 1; i++)
                {
                    students[i] = students[i+1];
                }
                students[n-1] = temp;
                count++;
            }
        }
        return n;
    }
}