using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEvaluater
{
    internal class ExpressionEvaluateService
    {
        internal static bool Evaluate(string expression)
        {
            // Identify the operator in the expression
            char[] operators = { '=', '<', '>' };
            int operatorIndex = expression.IndexOfAny(operators);

            if (operatorIndex == -1)
            {
                // No operator found, invalid expression
                return false;
            }

            char op = expression[operatorIndex];
            string sideA = expression.Substring(0, operatorIndex);
            string sideB = expression.Substring(operatorIndex + 1);

            // Determine the type of the sides
            if (int.TryParse(sideA, out int numA) && int.TryParse(sideB, out int numB))
            {
                // Both sides are integers, compare numerically
                return CompareNumbers(numA, numB, op);
            }
            else if (bool.TryParse(sideA, out bool boolA) && bool.TryParse(sideB, out bool boolB))
            {
                // Both sides are booleans, compare based on boolean rules
                return CompareBooleans(boolA, boolB, op);
            }
            else
            {
                // Both sides are strings, compare lexicographically
                return CompareStrings(sideA, sideB, op);
            }
        }

        private static bool CompareNumbers(int numA, int numB, char op)
        {
            return op switch
            {
                '<' => numA < numB,
                '>' => numA > numB,
                '=' => numA == numB,
                _ => false
            };
        }

        private static bool CompareBooleans(bool boolA, bool boolB, char op)
        {
            return op switch
            {
                '=' => boolA == boolB,
                _ => false  // < and > are invalid for booleans
            };
        }

        private static bool CompareStrings(string strA, string strB, char op)
        {
            int comparisonResult = string.Compare(strA, strB, StringComparison.Ordinal);
            return op switch
            {
                '<' => comparisonResult < 0,
                '>' => comparisonResult > 0,
                '=' => comparisonResult == 0,
                _ => false
            };
        }
    }
}
