
using Leetcode.Exercises.CSharp.Structures;
namespace Leetcode.Exercises.CSharp.Medium
{
    // You are given two non-empty linked lists representing two non-negative integers.
    // The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    // You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    public static class AddTwoNumbersInLists
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currNode = new ListNode();
            ListNode root = currNode;
            var sum = 0;

            // loop while we have values in the lists or something leftover in the sum
            while (l1 != null || l2 != null || sum > 0)
            {
                // check if list nodes are defined and add it to the sum before moving to the next node
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // insert a new node with the resulting sum's last digit and set it as a flag if it has anything leftover
                currNode.next = new ListNode(sum % 10);
                sum /= 10;
                currNode = currNode.next;
            }

            return root.next;
        }
    }
}
