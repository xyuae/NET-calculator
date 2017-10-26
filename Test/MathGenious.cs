using System;
using System.Collections.Generic;

namespace Test
{
    public class MathGenious : ComplexMath, IComplexMath, IParenthesis
    {
        public override float EvaluateExpression(string expr)
        {
            // append () outside of string as sign for evaluation
            expr = HelpParenthesis(expr);
            return base.EvaluateExpression(expr);
        }

        public string HelpParenthesis(string expr)
        {
            Stack<int> open = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];
                if (c == '(') { open.Push(i); }
                else if (c == ')')
                {
                    if (open.Count == 0)
                    {
                        throw new InvalidOperationException("Error: No matching parenthesis");
                    }
                    int start = open.Pop();
                    int end = i;
                    float temp = base.EvaluateExpression(expr.Substring(start + 1, end - start - 1));
                    expr = expr.Substring(0, start) + temp.ToString() + expr.Substring(end + 1);    // update the string
                    i = start + temp.ToString().Length; // adjust the counter to the position next to the combined number. 
                }
            }
            return expr;
        }
    }
}
