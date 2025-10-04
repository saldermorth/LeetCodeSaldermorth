namespace LeetCodeSaldermorth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            var result = solution.TwoSum([2, 7, 11, 15], 9);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            result = solution.TwoSum([3, 2, 4], 6);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            result = solution.TwoSum([3, 3],  6);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int firstNumber = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (firstNumber + nums[j] == target)
                    {

                        return new int[] { i, j };

                    }
                }
            }

            return nums;
        }
    }

    /*Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 */
}

/*IMPROVED CODE
 
 
 public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>(); // value -> index

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (seen.TryGetValue(complement, out int index))
            {
                return new[] { index, i };
            }

            // store this number and its index
            seen[nums[i]] = i;
        }

        // if not found (shouldn’t happen if input is valid)
        return Array.Empty<int>();
    }
}*/