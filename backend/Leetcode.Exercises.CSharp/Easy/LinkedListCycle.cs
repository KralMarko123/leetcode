using Leetcode.Exercises.CSharp.Structures;

namespace Leetcode.Exercises.CSharp.Easy
{
    public static class LinkedListCycle
    {
        // Given head, the head of a linked list, determine if the linked list has a cycle in it.
        // There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
        // Return true if there is a cycle in the linked list. Otherwise, return false.
        public static bool HasCycle(ListNode head)
        {
            var dictionary = new Dictionary<ListNode, bool>();

            if (head == null || head.next == null) return false;
            while (head != null)
            {
                if (dictionary.ContainsKey(head)) return true;
                else dictionary.Add(head, true);
                head = head.next;
            }

            return false;
        }
    }
}
