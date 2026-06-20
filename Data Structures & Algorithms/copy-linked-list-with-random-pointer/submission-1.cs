/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        //them copy vao danh sach goc
        Node temp = head;
        while(temp != null){
            Node copy = new Node(temp.val);
            Node temp2 = temp.next;
            copy.next = temp2;
            temp.next = copy;
            temp = temp2;
        }
        //them con tro random
        temp = head;
        while(temp != null && temp.next != null){
            if(temp.random != null)
            temp.next.random = temp.random.next;
            temp = temp.next.next;
        }
        //tach danh sach copy
        temp = head;
        Node dummy = new Node(-1);
        Node copycat = dummy;
        while(temp != null){
            copycat.next = temp.next;
            copycat = copycat.next;
            temp.next = copycat.next;
            temp = temp.next;
        }
        return dummy.next;
    }
}
