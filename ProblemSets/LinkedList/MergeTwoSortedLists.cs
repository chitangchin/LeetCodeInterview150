using ProblemSets.LinkedList.LinkedListCycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.LinkedList.MergeTwoSortedLists
{
    public class MergeTwoSortedListsLeet
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null || list2 == null) return (list1 == null ? list2 : list1);
            ListNode prehead = new ListNode(-1);
            ListNode prev = prehead;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;

            }
            prev.next = list1 == null ? list2 : list1;
            return prehead.next;
        }
    }
}
