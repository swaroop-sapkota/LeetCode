public class RecentCounter {
    private List<int> pings;
    private int start;

    public RecentCounter() {
        pings = new List<int>();
        start = 0;
    }
    
    public int Ping(int t) {
        pings.Add(t);
        
        while (pings[start] < t - 3000)
        {
            start++;
        }
        return pings.Count - start;

    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */