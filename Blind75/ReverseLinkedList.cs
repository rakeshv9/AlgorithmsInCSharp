// Given the head of a singly linked list, reverse the list, and return the reversed list.

// Example 1:

// Input: head = [1,2,3,4,5]
// Output: [5,4,3,2,1]
-----------------------------------------------------------------------------------------


public class Blind75Questions
{  
    public class ListNode {
      public int val;
     public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }
    public ListNode ReverseList(ListNode head) {
        if(head == null) return head;
        ListNode current = head, prev = null;
        while(current != null){
            ListNode next = current.next; //store current.next in next node
            current.next = prev; //change the pointer direction backward
            prev = current; //move prev
            current = next; //move current

        }
        return prev; //at the end, prev will be the new head
    }
   
    public static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        Blind75Questions obj = new Blind75Questions();

        ListNode node = obj.ReverseList(head);
        Console.WriteLine("Reversed Linked List: ");
        while(node != null){
          Console.WriteLine(node.val);
          node = node.next;
        }
    }   
}
