using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.LinkedList.LinkedListCycle
{
    public class ListNode(int x)
    {
        public int val = x;
        public ListNode next = null!;
    }
    public class SolutionClass
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }
    }
}
