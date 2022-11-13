using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem2
{
    class AddTwoNumbers
    {

        public ListNode Add(ListNode l1, ListNode l2)
        {
            var start = new ListNode();
            var current = start;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                var sum = current.val + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);

                current.val = sum % 10;
                carry = (sum - current.val) / 10;

                if ((l1?.next != null || l2?.next != null) || carry > 0)
                    current.next = new ListNode(carry);

                current = current.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return start;
        }
    }
}
