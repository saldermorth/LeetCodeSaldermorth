namespace Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length < 2) return false;
            if (s.Length < 2 && s[0] != s[1]) return false;
            if (s.Length % 2 != 0) return false;
            if (s[0] == ']' || s[0] == ')' || s[0] == '}') return false;

            int amountOfLeftType = 0;
            int amountOfRightType = 0;
            char leftTypeToCheck = ' ';
            Dictionary<int, char >  indexSymbol = new Dictionary<int , char >();
            //Use dictionar for whole string?? look up index perhaps
            for (int i = 0; i < s.Length; i++)
            {
               //If we se a right type without prevously seeing a left type return
                if (s[i] == '(')
                {
                    indexSymbol.Add(i, s[i]);
                    // Start search of ) in loop 
                    for (int j = 1; j < s.Length; j++)
                    {
                        if (s[j] == ')')
                        {
                            indexSymbol.Add(j, s[j]);
                            //
                        }
                    }
                   
                }
                if (s[i] == '[')
                {
                    indexSymbol.Add(i, s[i]);
                    // Start search of ] in loop
                }
                if (s[i] == '{')
                {
                    indexSymbol.Add(i, s[i]);
                    // Start search of } in loop
                }
                if (s[i] == ')')
                {
                    indexSymbol.Add(i, s[i]);
                    // Start search of ) in loop

                }
                if (s[i] == ']')
                {
                    indexSymbol.Add(i, s[i]);
                    // Start search of ] in loop
                }
                if (s[i] == '}')
                {
                    indexSymbol.Add(i, s[i]);
                    // Start search of } in loop
                }
            }

           


            return false;
        }
    }

    /*
     
     Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

     An input string is valid if:
     
     Open brackets must be closed by the same type of brackets.
     Open brackets must be closed in the correct order.
     Every close bracket has a corresponding open bracket of the same type.
    
     Example 1:

     Input: s = "()"
     
     Output: true
     
     Example 2:
     
     Input: s = "()[]{}"
     
     Output: true
     
     Example 3:
     
     Input: s = "(]"
     
     Output: false
     
     Example 4:
     
     Input: s = "([])"
     
     Output: true
     
     Example 5:
     
     Input: s = "([)]"
     
     Output: false

 
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.IsValid("()[]{}");
           

            /*
             *40 = (
              41 = )
              91 = [
              93 = ]
              123 = {
              125 = }
            */
        }
    }
}
