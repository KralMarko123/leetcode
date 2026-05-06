using Leetcode.Exercises.CSharp.Structures;

namespace Leetcode.Exercises.CSharp.Easy
{
    // You are given the heads of two sorted linked lists list1 and list2.
    // Merge the two lists in a one sorted list.The list should be made by splicing together the nodes of the first two lists.
    // Return the head of the merged linked list
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var startingNode = new ListNode();
            var movingNode = startingNode;
            var p1 = list1;
            var p2 = list2;

            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    movingNode.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    movingNode.next = p2;
                    p2 = p2.next;
                }

                movingNode = movingNode.next;
            }

            movingNode.next = p1 ?? p2;

            return startingNode.next;
        }
    }
}
