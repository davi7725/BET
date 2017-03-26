using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BET
{
    class BET
    {
        Node root = null;


        public void Insert(string[] instructions)
        {
            int i = 0;
            root = returnRootNode(instructions, ref i);
        }

        private Node returnRootNode(string[] instructions, ref int index)
        {
            if (instructions.Length - 1 >= index)
            {
                if (instructions[index] != "null")
                {
                    int tmpIndex = index;
                    index++;
                    Node left = returnRootNode(instructions, ref index);
                    index++;
                    Node right = returnRootNode(instructions, ref index);
                    Node newNode = new Node();
                    newNode.Data = instructions[tmpIndex];
                    newNode.left = left;
                    newNode.right = right;
                    return newNode;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public List<string> InOrder()
        {
            return InOrder(root);
        }

        private List<string> InOrder(Node pointer)
        {
            List<string> listInOrder = new List<string>();
            if (pointer != null)
            {
                if(pointer.left != null && pointer.right != null)
                    listInOrder.Add("(");
                listInOrder.AddRange(InOrder(pointer.left));
                listInOrder.Add(pointer.Data);
                listInOrder.AddRange(InOrder(pointer.right));
                if (pointer.left != null && pointer.right != null)
                    listInOrder.Add(")");
            }
            return listInOrder;
        }
        
    }
}
