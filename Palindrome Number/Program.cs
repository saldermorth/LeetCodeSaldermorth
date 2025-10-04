namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.IsPalindrome(1211);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            
            var numAsStringReversed = x.ToString().Reverse().ToArray();
            var numAsString = x.ToString().ToArray();

            if (numAsString[0] != numAsStringReversed[0]) return false;

            for (int i = 0; i < numAsStringReversed.Length; i++)
            {
                if (numAsStringReversed[i] != numAsString[i])
                {
                    return false;
                }
            }
           
            return true;
        }
    }
}
/*Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 */