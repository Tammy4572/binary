using System;
using System.Collections.Generic;

namespace BinaryTreeDemo
{
    class BinaryExpressionTree
    {
        public int Count { get; set; }
        public BinaryNode<char> RootNode;
        public string Expression { get; private set; }

        public BinaryExpressionTree(String expression)
        {
            this.Expression = expression;
            // get rid of the pesky spaces
            Console.WriteLine(expression);
            Queue<char> expr = new Queue<char>(expression.ToCharArray());
            RootNode = Parse(expr);
        }
        
        public BinaryNode<char> Parse(Queue<char> expressionQueue)
        {
            BinaryNode<char> myNode = new BinaryNode<char>();
            char nextChar;

            // consume the paren, throw it away
            expressionQueue.Dequeue();
            // get the next character
            nextChar = expressionQueue.Dequeue();
            // possibilities are left paren or value
            if (nextChar == '(')
            {
                // TODO -- action if left side is an expression
            }
            else
            {
                // TODO -- action if left side is a value
                // TODO -- don't forget to consume the value
            }

            // should be at operand
            // TODO -- deal with the operand

            // TODO -- consume the operator

            // possibilities are left paren or value
            // TODO -- get nextChar
            if (nextChar == '(')
            {
                // TODO -- action if left side is an expression
            }
            else
            {
                // TODO -- action if left side is a value
                // TODO -- don't forget to consume the value
            }
            // consume the right paren, throw it away
            expressionQueue.Dequeue();
            return myNode;
        }

        public void DisplayPreOrder()
        {
            // TODO create code to perform a preorder traversal
            // You may need one other method
        }

        public void DisplayPostOrder()
        {
            // TODO create code to perform a postorder traversal
            // You may need one other method
        }

        public double Eval()
        {
            return Eval(RootNode);
        }

        private double Eval(BinaryNode<char> node)
        {
            double value = 0;
            if (node.isLeaf())
            {
                // cheap way to convert a single digit number to an integer
                value = node.item - '0';
            }
            else {
                switch (node.item)
                {
                    case '+':
                        // TODO evaluate operator
                        break;
                    case '-':
                        // TODO evaluate operator
                        break;
                    case '*':
                        // TODO evaluate operator
                        break;
                    case '/':
                        // TODO evaluate operator
                        break;
                    default:
                        Console.WriteLine("Invalid OP {0}", node.item);
                        value = 0;
                        break;
                }
            }

            return value;
        }

        public void DisplayInOrder()
        {
            if (RootNode != null)
            {
                DisplayInOrder(RootNode);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Tree is empty.");
            }
        }

        private void DisplayInOrder(BinaryNode<char> node)
        {
            if (node.left != null)
            {
                Console.Write('(');
                DisplayInOrder(node.left);
            }
            Console.Write(node.item);
            if (node.right != null)
            {
                DisplayInOrder(node.right);
                Console.Write(')');
            }
        }

    }
}
