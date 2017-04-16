using System;

namespace BinaryTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string expression = "((3 * (8 - 2)) - (1 + 9))";
            BinaryExpressionTree bet =  new BinaryExpressionTree(expression);
            Console.Write("Infix: ");
            bet.DisplayInOrder();
            Console.Write("Postfix: ");
            bet.DisplayPostOrder();
            Console.Write("Prefix: ");
            bet.DisplayPreOrder();
            Console.WriteLine("{0} = {1}", bet.Expression, bet.Eval());
            

            Console.ReadLine();
        }
    }
}
