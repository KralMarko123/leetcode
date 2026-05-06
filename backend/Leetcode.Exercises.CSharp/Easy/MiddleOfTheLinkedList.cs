using Leetcode.Exercises.CSharp.Structures;

namespace LeetcodeExercises.Easy
{
    //Given the head of a singly linked list, return the middle node of the linked list.
    //If there are two middle nodes, return the second middle node.
    public static class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            if (head.next == null) return head;

            var helperNode = head;
            var numberOfNodes = 0;

            while (helperNode != null)
            {
                numberOfNodes++;
                helperNode = helperNode.next;
            }

            var atNode = 1;

            while (head != null)
            {
                if (atNode == (numberOfNodes / 2) + 1) return head;

                atNode++;
                head = head.next;
            }

            return head!;
        }

        public static ListNode MiddleNodeTwoPointer(ListNode head)
        {
            if (head.next == null) return head;

            var helperNode = head.next;

            while (helperNode != null)
            {
                head = head.next;
                helperNode = helperNode.next;

                if (helperNode != null) helperNode = helperNode.next;
            }

            return head;
        }
    }
}
