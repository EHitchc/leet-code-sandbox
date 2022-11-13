using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem147
{
    class InsertSortLinkedList
    {
        public ListNode InsertionSortList(ListNode head)
        {
            // Initialize sorted linked list
            ListNode sortedHead = null;
            ListNode current = head;

            // Traverse the given 
            // linked list and insert every
            // node to sorted
            while (current != null)
            {
                // Store next for next iteration
                ListNode next = current.next;

                // insert current in sorted linked list
                // Special case for the head end
                if (sortedHead == null || sortedHead.val >= current.val)
                {
                    current.next = sortedHead;
                    sortedHead = current;
                }
                else
                {
                    ListNode prevNode = sortedHead;

                    /* Locate the node before the point of insertion */
                    while (prevNode.next != null &&
                            prevNode.next.val < current.val)
                    {
                        prevNode = prevNode.next;
                    }
                    current.next = prevNode.next;
                    prevNode.next = current;
                }

                // Update current
                current = next;
            }

            return sortedHead;
        }
    }
