using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengesCSharp
{
    class BinaryTree
    {
        public bool Search(Node node, int number)
        {
            if (node.Value == number) return true;
            //if (node.Value == null) {return false;}
            if (node.Value < number)
            {
                Search(node.Left, number);
            }

            if (node.Value > number)
            {
                Search(node.Right, number);
            }

            return false;
        }

        public void Insert(Node node)
        {
            //explore the nodes left or right based on value till null is found, set node left or right as passed node. 
            //balance the tree.
            //if (!IsBalanced())
            //{
            //    Balance();
            //}
            
        }

        public void Balance(Node n)
        {
          //add all nodes to list
          
          //find middle

          //create tree
        }

        public bool IsBalanced(Node n)
        {
            if (BalancedHeight(n) > -1) return true;
            return false;
        }

        public int BalancedHeight(Node n)
        {
            if (n == null) return 0;
            int h1 = BalancedHeight(n.Left);
            int h2 = BalancedHeight(n.Right);

            if (h1 == -1 || h2 == -1) return -1;
            if (Math.Abs(h1 - h2) > 1) return -1;

            if (h1 > h2) return h1 + 1;
            return h2 + 1;
        }
    }
}
