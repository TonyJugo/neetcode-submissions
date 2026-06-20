/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        //tach 2 nua
        ListNode rabbit = head;
        ListNode turtle = head;
        while(rabbit != null && rabbit.next != null){
            rabbit = rabbit.next.next;
            turtle = turtle.next;
        }
        ListNode secondHalf = turtle.next;
        turtle.next = null;
        //dao nguoc second half
        ListNode prev = null;
        ListNode cur = secondHalf;
        ListNode temp = new ListNode(-1);
        while(cur != null){
            temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }
        //merge 
        ListNode second = prev;
        while(second != null){
            ListNode temp1 = head.next;
            ListNode temp2 = second.next;
            head.next = second;
            second.next = temp1;
            head = temp1;
            second = temp2;
        }
    }
}
