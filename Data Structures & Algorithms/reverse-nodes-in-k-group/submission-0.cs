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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1) return head;

        // 1. Tạo Dummy Node đứng trước head để quản lý mạch dễ hơn
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        // groupPrev là nút đứng ngay trước cụm k phần tử chuẩn bị đảo
        ListNode groupPrev = dummy; 
        
        while (true) {
            // 2. Tìm nút cuối của cụm k phần tử
            ListNode kth = GetKthNode(groupPrev, k);
            if (kth == null) break; // Nếu không đủ k nút thì ngưng
            
            ListNode groupNext = kth.next; // Nút bắt đầu của phần còn lại
            
            // 3. Đảo ngược cụm k phần tử
            ListNode prev = groupNext; // Đuôi mới sẽ nối thẳng vào phần còn lại
            ListNode curr = groupPrev.next;
            
            while (curr != groupNext) {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            
            // 4. Cập nhật lại các mối nối sau khi đảo
            ListNode tmp = groupPrev.next; 
            groupPrev.next = kth; // Nối phần trước vào đầu mới của cụm
            groupPrev = tmp;      // Dời groupPrev tới đuôi mới của cụm để cbi lượt sau
        }
        
        return dummy.next;
    }

    // Hàm phụ trợ giúp đếm và tìm nút thứ k cho code gọn gàng
    private ListNode GetKthNode(ListNode curr, int k) {
        while (curr != null && k > 0) {
            curr = curr.next;
            k--;
        }
        return curr;
    }
}
