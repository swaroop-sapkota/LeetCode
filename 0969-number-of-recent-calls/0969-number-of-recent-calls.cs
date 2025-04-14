public class RecentCounter {
    private List<int> requests;
    private int startIndex;

    public RecentCounter() {
        requests = new List<int>();
        startIndex = 0;
    }
    
    public int Ping(int t) {
        requests.Add(t);

        while (requests[startIndex] < t - 3000)
        {
            startIndex++;
        }

        return requests.Count - startIndex;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */