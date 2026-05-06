using Leetcode.Exercises.CSharp.Structures;
using System.Text;

namespace Leetcode.Exercises.CSharp.Helpers
{
    public static class ListHelpers
    {
        public static ListNode GenerateListFromArray(int[] arr)
        {
            ListNode resultingHead = null;

            for (int i = 0; i < arr.Length; i++)
            {
                resultingHead = InsertNode(resultingHead, arr[i]);
            }

            return resultingHead;
        }

        public static ListNode GenerateListFromString(string s)
        {
            ListNode resultingHead = null;

            for (int i = 0; i < s.Length; i++)
            {
                resultingHead = InsertNode(resultingHead, int.Parse(s[i].ToString()));
            }

            return resultingHead;
        }

        public static ListNode GenerateListFromInteger(int number)
        {
            return GenerateListFromString(number.ToString());
        }

        public static ListNode InsertNode(ListNode head, int item)
        {
            ListNode temp = new ListNode();
            ListNode ptr;

            temp.val = item;
            temp.next = null;

            if (head == null) head = temp;
            else
            {
                ptr = head;

                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }

                ptr.next = temp;
            }
            return head;
        }

        public static string GetListAsString(ListNode head, string separator = "")
        {
            var sb = new StringBuilder();

            while (head != null)
            {
                sb.Append(head.val);

                if (head.next != null) sb.Append(separator);

                head = head.next!;
            }

            return sb.ToString();
        }

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
