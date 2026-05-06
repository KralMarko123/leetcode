
using Leetcode.Exercises.CSharp.Structures;

namespace Leetcode.Exercises.CSharp.Easy
{
    // Given the head of a singly linked list, reverse the list, and return the reversed list.
    public static class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode previousNode = null;
            ListNode nextNode = null;

            while (head != null)
            {
                nextNode = head.next;
                head.next = previousNode;
                previousNode = head;
                head = nextNode;
            }

            return previousNode;
        }
    }
}
