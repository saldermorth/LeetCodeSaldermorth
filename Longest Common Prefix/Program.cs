using System.Text;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a function to find the longest common prefix string amongst an array of strings.
            Solution solution = new Solution();
            var result = solution.LongestCommonPrefix(["", ""]);
            Console.WriteLine("The result is " + result);
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            int shortestStr = strs.OrderBy(x => x.Length).First().Length;

            if (shortestStr == 0) return "";

            StringBuilder match = new StringBuilder();
            int shortestStringLength = strs.OrderBy(z => z.Length).First().Length;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[0][0] != strs[i][0]) return "";
            }
            match.Append(strs[0][0]);


            for (int position = 1; position < shortestStringLength; position++)
            {
                char charToCompare = strs[0][position];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (charToCompare != strs[j][position])                     {
                    
                        return match.ToString();
                    }
                }
                        match.Append(charToCompare);
            }
            return match.ToString();
        }
    }
}

/*Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.*/
