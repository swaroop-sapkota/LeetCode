public class MyStack {

    ListNode head;

    public MyStack() {
        head = null;    
    }
    
    public void Push(int x) {
       ListNode node = new ListNode(x);

       node.next = head;

       head = node; 
    }
    
    public int Pop() {
        int number = head.val;

        head = head.next;

        return number;
    }
    
    public int Top() {
        return head.val;
    }
    
    public bool Empty() {
        return head == null;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */