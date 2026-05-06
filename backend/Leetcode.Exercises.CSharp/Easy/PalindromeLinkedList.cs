
using Leetcode.Exercises.CSharp.Structures;
using System.Text;

namespace Leetcode.Exercises.CSharp.Easy
{
    // Given the head of a singly linked list, return true if it is palindrome or false otherwise.
    public static class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            var sb = new StringBuilder();

            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }

            for (int i = 0, j = sb.Length - 1; i < sb.Length / 2; i++, j--)
            {
                if (sb[i] != sb[j]) return false;
            }

            return true;
        }
    }
}
