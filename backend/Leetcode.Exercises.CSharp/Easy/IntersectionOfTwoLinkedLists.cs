
using Leetcode.Exercises.CSharp.Structures;

namespace Leetcode.Exercises.CSharp.Easy
{
    // Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect.
    // If the two linked lists have no intersection at all, return null.
    public static class IntersectionOfTwoLinkedLists
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var set = new HashSet<ListNode>();
            var p1 = headA;
            var p2 = headB;

            while (p1 != null)
            {
                set.Add(p1);
                p1 = p1.next;
            }

            while (p2 != null)
            {
                if (set.Contains(p2)) return p2;
                p2 = p2.next;
            }

            return null;
        }
    }
}
