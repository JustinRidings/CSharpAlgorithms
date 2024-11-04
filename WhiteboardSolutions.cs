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
}
