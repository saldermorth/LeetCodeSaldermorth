namespace Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            var num = solution.RomanToInt("MCMXCIV");
            Console.WriteLine(num);
        }
    }

    public class Solution

    {
        public int RomanToInt(string s)
        {
           
            int sum = 0;
            Dictionary<char, int> romanNumerals = new Dictionary<char, int>
            {
                { 'I', 1 },{ 'V', 5 },{ 'X', 10  },{  'L', 50 },{ 'C', 100  },{ 'D', 500 },{ 'M', 1000 }                
            };

            //LOOP trough att char in s
            for (int i = 0; i < s.Length; i++)
            {
                //if there is a next number
                if (i + 1 < s.Length)
                {
                    if (romanNumerals[s[i]] < romanNumerals[s[i + 1]])
                    {
                        sum -= romanNumerals[s[i]];
                        sum += romanNumerals[s[i + 1]]; 
                        i++;  
                    }
                    else
                    {
                        sum += romanNumerals[s[i]];
                    }
                }
                else
                {
                    sum += romanNumerals[s[i]];
                }
            }

            return sum;
        }
       
    }


    /*Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.*/
}
