using LeetCodeSandbox.Problems.Problem147;
using System;

namespace LeetCodeSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // [-1,0,3,4,5]
            //var linkedListHead = new ListNode(-1, 
            //    new ListNode(0, 
            //    new ListNode(3,
            //    new ListNode(4,
            //    new ListNode(5)))));

            // [4,19,14,5,-3,1,8,5,11,15]
            var linkedListHead = new ListNode(4,
                new ListNode(19,
                new ListNode(14,
                new ListNode(5,
                new ListNode(-3,
                new ListNode(1,
                new ListNode(8,
                new ListNode(5,
                new ListNode(11,
                new ListNode(15))))))))));

            var test = new InsertSortLinkedList();
            Console.WriteLine(test.InsertionSortList(linkedListHead));
        }
    }
}
