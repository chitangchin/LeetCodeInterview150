using System.Collections.Generic;

using ProblemSets.LinkedList.LinkedListCycle;

namespace ProblemSetTests.LinkedList
{
    public class LinkedListCycleTest
    {
        [Test]
        public void Test()
        {    
            ListNode linkedList = new ListNode(3);
            linkedList.next = new ListNode(2);
            linkedList.next = new ListNode(0);
            linkedList.next = new ListNode(-4);

            Assert.That(SolutionClass.HasCycle(linkedList), Is.False);
        }
    }
}
