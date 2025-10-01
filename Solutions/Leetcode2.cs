/**
 * Definition for singly-linked list. */
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }
 
public class LeetCode2 {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return AddwithCarry(l1, l2,0);
    }
    public ListNode AddwithCarry(ListNode? l1, ListNode? l2, int carry)
    {
        if(l1 is null && carry ==0)
        return l2;
        if(l2 is null && carry ==0)
        return l1;
        ListNode l3 = new ListNode();
        l3.val = (l1?.val??0) + (l2?.val??0) + carry;
        if(l3.val>9 || l1?.next is not null || l2?.next is not null)
        {
            carry = (l3.val)/10;
            l3.val = (l3.val)%10;
            l3.next = AddwithCarry(l1?.next,l2?.next,carry);
        }
        return l3;
    }
}