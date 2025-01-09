public static class WhiteboardSolutions
{
    /// <summary>
    /// Determines if the input string is spelled the same in both directions
    /// </summary>
    /// <param name="input">Word to check</param>
    /// <returns>True if spelled the same both directions</returns>
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (char.ToLower(input[left]) != char.ToLower(input[right]))
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    /// <summary>
    /// Prints numbers from 1 to n, with multiples of 3 printing "Fizz", multiples of 5 printing "Buzz", and for multiples
    /// of 3 AND 5 prints "FizBuzz".
    /// </summary>
    /// <param name="n">Count limit</param>
    public static void FizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    /// <summary>
    /// Reverses a string
    /// </summary>
    /// <param name="input">string to be reversed</param>
    /// <returns>Reversed string</returns>
    public static string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        char[] charArray = input.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }

        return new string(charArray);
    }

    /// <summary>
    /// Counts the maximum number of duplicate characters in a string
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Maximum number of duplicate characters in string.</returns>
    public static int CountDuplicateCharacters(string input)
    {
        if (!string.IsNullOrWhiteSpace(input))
        {
            input = input.ToUpperInvariant();
            Dictionary<char, int> countDict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (countDict.ContainsKey(input[i]))
                {
                    countDict[input[i]]++;
                }
                else
                {
                    countDict.Add(input[i], 1);
                }
            }
            return countDict.Count(kvp => kvp.Value > 1);
        }
        return 0;
    }

    /// <summary>
    /// Reverses a LinkedList
    /// </summary>
    /// <typeparam name="T">Type of LinkedList</typeparam>
    /// <param name="inputList">List to Reverse</param>
    /// <returns>Reversed List</returns>
    public static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> inputList)
    {
        LinkedList<T> reversedList = new LinkedList<T>();

        var currentNode = inputList.Last;
        while (currentNode != null)
        {
            reversedList.AddLast(currentNode.Value);
            currentNode = currentNode.Previous;
        }

        return reversedList;
    }

    /// <summary>
    /// Given two LinkedLists, combines them
    /// </summary>
    /// <typeparam name="T">Type of Linked List</typeparam>
    /// <param name="list1">First List</param>
    /// <param name="list2">Second List</param>
    /// <returns>Combined LinkedList</returns>
    public static LinkedList<T> CombineLists<T>(LinkedList<T> list1, LinkedList<T> list2)
    {
        LinkedList<T> combinedList = new LinkedList<T>();

        var node1 = list1.First;
        var node2 = list2.First;

        while (node1 != null && node2 != null)
        {
            if (Comparer<T>.Default.Compare(node1.Value, node2.Value) < 0)
            {
                combinedList.AddLast(node1.Value);
                node1 = node1.Next;
            }
            else
            {
                combinedList.AddLast(node2.Value);
                node2 = node2.Next;
            }
        }

        while (node1 != null)
        {
            combinedList.AddLast(node1.Value);
            node1 = node1.Next;
        }

        while (node2 != null)
        {
            combinedList.AddLast(node2.Value);
            node2 = node2.Next;
        }

        return combinedList;
    }

    /// <summary>
    /// Finds two numbers in an array that add up to a target number
    /// </summary>
    /// <param name="nums">Array of numbers</param>
    /// <param name="target">Target Sum number</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Thrown when there is no solution.</exception>
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }

    /// <summary>
    /// Finds the length of the longest substring without repeating characters
    /// </summary>
    /// <param name="s">Input string</param>
    /// <returns>Length of substring</returns>
    public static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxLength = 0, left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            if (map.ContainsKey(s[right]))
            {
                left = Math.Max(map[s[right]] + 1, left);
            }
            map[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }

    /// <summary>
    /// Finds the area of the largest rectangle that can be formed in a histogram
    /// </summary>
    /// <param name="heights">Array of heights representing the histograms bars</param>
    /// <returns>The maximum area of the rectangle</returns>
    public static int LargestRectangleArea(int[] heights)
    {
        if (heights == null || heights.Length == 0)
        {
            return 0;
        }

        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        int index = 0;

        while (index < heights.Length)
        {
            if (stack.Count == 0 || heights[stack.Peek()] <= heights[index])
            {
                stack.Push(index++);
            }
            else
            {
                int height = heights[stack.Pop()];
                int width = stack.Count == 0 ? index : index - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }
        }

        while (stack.Count > 0)
        {
            int height = heights[stack.Pop()];
            int width = stack.Count == 0 ? index : index - stack.Peek() - 1;
            maxArea = Math.Max(maxArea, height * width);
        }

        return maxArea;
    }

    /// <summary>
    /// Accepts a non-negative integer and returns its factorial using recursion
    /// </summary>
    /// <param name="n">Non-negative integer</param>
    /// <returns>Factorial</returns>
    /// <exception cref="ArgumentException">When the input is negative</exception>
    public static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Input must be a non-negative integer");
        }
        if (n == 0)
        {
            return 1;
        }

        return n * CalculateFactorial(n - 1);

        // Alternate solution using LINQ:
        // return Enumerable.Range(1, n).Aggregate(1L, (acc, x) => acc * x);
    }
}
