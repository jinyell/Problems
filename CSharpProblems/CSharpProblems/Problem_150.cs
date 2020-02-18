/*
 * Problem 150: Evaluate Reverse Polish Notation
 * Difficulty: Medium
 * 
 * Evaluate the value of an arithmetic expression in Reverse Polish Notation.
 * 
 * Valid operators are +, -, *, /. Each operand may be an integer or 
 * another expression.
 * 
 * Note:
 *     Division between two integers should truncate toward zero.
 *     The given RPN expression is always valid. That means the expression 
 * 	   would always evaluate to a result and there won't be any divide by 
 * 	   zero operation.
 * 
 * Example 1:
 *      Input: ["2", "1", "+", "3", "*"]
 *      Output: 9
 *      Explanation: ((2 + 1) * 3) = 9
 * 
 * Example 2:
 *      Input: ["4", "13", "5", "/", "+"]
 *      Output: 6
 *      Explanation: (4 + (13 / 5)) = 6
 * 
 * Example 3:
 *      Input: ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", 
				"5", "+"]
 *      Output: 22
 *      Explanation: 
 *            ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
 *          = ((10 * (6 / (12 * -11))) + 17) + 5
 *          = ((10 * (6 / -132)) + 17) + 5
 *          = ((10 * 0) + 17) + 5
 *          = (0 + 17) + 5
 *          = 17 + 5
 *          = 22
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_150
    {
        public class Solution
        {
            public int EvalRPN(string[] tokens)
            {
                Stack<string> stack = new Stack<string>();

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (IsOperator(tokens[i]))
                    {
                        CalculateOperator(stack, tokens[i]);
                    }
                    else
                    {
                        stack.Push(tokens[i]);
                    }
                }

                return int.Parse(stack.Pop());
            }

            private bool IsOperator(string mathOperator)
            {
                return (mathOperator == "+") || (mathOperator == "-") ||
                       (mathOperator == "*") || (mathOperator == "/");
            }

            private void CalculateOperator(Stack<string> stack,
                                           string mathOperator)
            {
                int firstNum = int.Parse(stack.Pop());
                int secondNum = int.Parse(stack.Pop());

                switch (mathOperator)
                {
                    case "+":
                        stack.Push((firstNum + secondNum).ToString());
                        break;
                    case "-":
                        stack.Push((secondNum - firstNum).ToString());
                        break;
                    case "*":
                        stack.Push((firstNum * secondNum).ToString());
                        break;
                    case "/":
                        stack.Push((secondNum / firstNum).ToString());
                        break;
                    default: break;
                }
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
