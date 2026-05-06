using Leetcode.Exercises.CSharp.Structures;

namespace Leetcode.Exercises.CSharp.Medium
{
    // Given the head of a linked list, remove the nth node from the end of the list and return its head.
    public static class RemoveNthNodeFromEndOfList
    {
        public static ListNode? RemoveNthFromEnd(ListNode head, int n)
        {
            int length = 0, pos = 1;
            ListNode p = head;

            while (p != null)
            {
                length++;
                p = p.next;
            }

            if (length == 1) return null;

            p = head;

            while (p != null)
            {
                if (pos == length - n)
                {
                    p.next = p.next.next;
                    break;
                }

                if (pos > length - n)
                {
                    head = p.next;
                    break;
                }

                pos++;
                p = p.next;
            }

            return head;
        }
    }
}
