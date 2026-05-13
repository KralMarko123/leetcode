export const BEST_TIME_TO_BUY_AND_SELL_STOCK_SNIPPET = `public static int MaxProfit(int[] prices) {
  if (prices.Length == 1) return 0;

  var maxProfit = 0;
  var cheapestStockDay = 0;

  for (var dayOfStock = 1; dayOfStock < prices.Length; dayOfStock++) {
    var profit = prices[dayOfStock] - prices[cheapestStockDay];

    if (profit > maxProfit)
      maxProfit = profit;
    
    if (prices[dayOfStock] < prices[cheapestStockDay])
      cheapestStockDay = dayOfStock;
  }

  return maxProfit;
}`;
export const BINARY_SEARCH_SNIPPET = `public static int Search(int[] nums, int target) {
  var result = Array.BinarySearch(nums, target);
  return result < 0 ? 0 : result;
}

public static int SearchUsingOwnBinarySearch(int[] nums, int target) {
  var start = 0;
  var end = nums.Length - 1;

  while (start <= end) {
    var halfway = start + (end - start) / 2;

    if (nums[halfway] == target) return halfway;

    if (nums[halfway] > target) end = halfway - 1;
    else start = halfway + 1;
  }

  return -1;
}`;
export const ARITHMETIC_PROGRESSION_SNIPPET = `public static bool CanMakeArithmeticProgression(int[] arr) {
  // Step 1: Find min, max, and difference
  var minElement = arr.Min();
  var maxElement = arr.Max();
  var difference = (maxElement - minElement) / (arr.Length - 1);

  // Step 2: Check if difference can be equally distributed 
  if ((maxElement - minElement) % (arr.Length - 1) != 0) return false;

  // Step 3: Check if difference is zero meaning all elements are the same number
  if (difference == 0) return true;

  var set = new HashSet < int > ();
  
  // Step 4: Check if each element is divisible by the difference and exists only once in the array
  foreach(var num in arr) {
    if ((num - minElement) % difference != 0 || set.Contains(num)) return false;

    set.Add(num);
  }

  return true;
}`;
export const LONGEST_CONSECUTIVE_SEQUENCE_SNIPPET = `public static int LongestConsecutive(int[] nums) {
  if (nums.Length <= 1) return nums.Length;

  // hashset lookup is O(1)
  var set = nums.ToHashSet();
  var maxSequence = 1;

  foreach(var num in nums) {
    if (set.Contains(num - 1)) continue;

    var sequence = 1;

    // since lookup is O(1) worst case scenario is an interrupted sequence which would result in O(N)
    while (set.Contains(num + sequence)) sequence++;

    maxSequence = maxSequence < sequence ? sequence : maxSequence;
  }

  return maxSequence;
}`;
export const MIN_STACK_SNIPPET = `public static class MinStack {
  private List < int > Elements;
  private List < int > MinimalElements;

  public MinStack() {
    Elements = new List < int > ();
    MinimalElements = new List < int > ();
  }

  public void Push(int val) {
    if (Elements.Count == 0 || val <= MinimalElements.Last()) MinimalElements.Add(val);
    Elements.Add(val);
  }

  public void Pop() {
    if (Elements.ElementAt(Elements.Count - 1) == MinimalElements.Last())
      MinimalElements.RemoveAt(MinimalElements.Count - 1);

    Elements.RemoveAt(Elements.Count - 1);
  }

  public int Top() {
    return Elements.Last();
  }

  public int GetMin() {
    return MinimalElements.Last();
  }
}`;
export const CAN_PLACE_FLOWERS_SNIPPET = `public static bool CanPlaceNumberOfFlowers(int[] flowerbed, int n) {
  for (int i = 0; i < flowerbed.Length; i++) {
    if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) &&
      (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {
      flowerbed[i] = 1;
      n--;
    }
  }

  return n <= 0;
}`;
export const CONTAINS_DUPLICATE_SNIPPET = `public static bool ContainsDuplicate(int[] nums) {
  var dictionary = new Dictionary < int,
    bool > ();

  foreach(var num in nums) {
    if (dictionary.ContainsKey(num)) return true;
    else dictionary.Add(num, true);
  }

  return false;
}

public static bool ContainsDuplicateWithHashSet(int[] nums) {
  return new HashSet < int > (nums).Count != nums.Length;
}`;
export const CONTAINS_DUPLICATE_TWO_SNIPPET = `public static bool ContainsNearbyDuplicate(int[] nums, int k) {
  var dict = new Dictionary < int, int > ();

  for (int i = 0; i < nums.Length; i++) {
    if (dict.ContainsKey(nums[i]) && (i - dict[nums[i]]) <= k) return true;
    else dict[nums[i]] = i;
  }

  return false;
}`;
export const EXCEL_SHEET_COLUMN_NUMBER_SNIPPET = `public static int TitleToNumber(string columnTitle) {
  int result = 0;
  var dictionary = new Dictionary<char, int>()
    {
        { 'A', 1 },
        { 'B', 2 },
        { 'C', 3 },
        { 'D', 4 },
        { 'E', 5 },
        { 'F', 6 },
        { 'G', 7 },
        { 'H', 8 },
        { 'I', 9 },
        { 'J', 10 },
        { 'K', 11 },
        { 'L', 12 },
        { 'M', 13 },
        { 'N', 14 },
        { 'O', 15 },
        { 'P', 16 },
        { 'Q', 17 },
        { 'R', 18 },
        { 'S', 19 },
        { 'T', 20 },
        { 'U', 21 },
        { 'V', 22 },
        { 'W', 23 },
        { 'X', 24 },
        { 'Y', 25 },
        { 'Z', 26 },
    };

  for (int i = 0; i < columnTitle.Length; i++) {
    result += (int) Math.Pow(26, columnTitle.Length - i - 1) * dictionary[columnTitle[i]];
  }

  return result;
}`;
export const FIND_NUMBERS_WITH_EVEN_NUMBER_OF_DIGITS_SNIPPET = `public static int FindNumbersOneLiner(int[] nums) {
  return nums.Count(n => n.ToString().Length % 2 == 0);
}`;
export const FIND_INDEX_OF_FIRST_OCCURRENCE_IN_A_STRING_SNIPPET = `public static int FindIndexOfFirstOccurence(string haystack, string needle) {
  if (needle.Length > haystack.Length) return -1;

  for (int i = 0; i < haystack.Length; i++) {
    if (haystack.Length - i < needle.Length) return -1;

    if (haystack[i] == needle[0]) {
      var lettersPassed = 0;

      for (int j = i; lettersPassed < needle.Length; j++) {
        if (haystack[j] == needle[lettersPassed]) lettersPassed++;
        else break;
      }

      if (lettersPassed == needle.Length) return i;
    }
  }

  return -1;
}`;
export const FIRST_UNIQUE_CHARACTER_IN_A_STRING_SNIPPET = `public static int FirstUniqChar(string s) {
  var dict = new Dictionary < char, int > ();

  foreach(var character in s) {
    if (!dict.ContainsKey(character)) dict[character] = 1;
    else dict[character]++;
  }

  for (int i = 0; i < s.Length; i++) {
    if (dict[s[i]] == 1) return i;
  }

  return -1;
}`;
export const FIZZ_BUZZ_SNIPPET = `public static IList < string > FizzBuzz(int n) {
  var result = new List < string > ();

  foreach(var digit in Enumerable.Range(1, n)) {
    var text = "";

    if (digit % 3 != 0 && digit % 5 != 0) text += digit.ToString();
    if (digit % 3 == 0) text += "Fizz";
    if (digit % 5 == 0) text += "Buzz";

    result.Add(text);
  }

  return result;
}`;
export const HAPPY_NUMBER_SNIPPET = `public static bool IsHappy(int n) {
  if (n == 1) return true;

  var set = new HashSet < int > ();

  while (true) {
    n = GetSumOfSquaredDigitsInNumber(n);

    if (n == 1) return true;
    else if (set.Contains(n)) return false;

    set.Add(n);
  }
}

private static int GetSumOfSquaredDigitsInNumber(int n) {
  var sum = 0;

  while (n != 0) {
    sum += (int) Math.Pow(n % 10, 2);
    n /= 10;
  }

  return sum;
}`;
export const INTERSECTION_OF_TWO_ARRAYS_SNIPPET = `public static int[] Intersect(int[] nums1, int[] nums2) {
  var setOne = new HashSet < int > (nums1);
  var setTwo = new HashSet < int > (nums2);
  var result = new List < int > ();

  foreach(var num in setTwo) {
    if (setOne.Contains(num)) result.Add(num);
  }

  return result.ToArray();
}`;
export const REVER_INTEGER_SNIPPET = `public static int ReverseUsingQueue(int x) {
  if (x / 10 == 0) return x;

  while (x % 10 == 0) x /= 10;

  var queue = new Queue < int > ();
  bool isNegative = x < 0;
  int reversedInt = 0;

  while (x != 0) {
    queue.Enqueue(Math.Abs(x % 10));
    x /= 10;
  }

  if (!int.TryParse(string.Join("", queue), out int value)) return 0;

  while (queue.Count > 0) reversedInt = reversedInt * 10 + queue.Dequeue();

  return isNegative ? reversedInt * -1 : reversedInt;
}`;
export const MEDIAN_OF_TWO_SORTED_ARRAYS_SNIPPET = `public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
  int i = 0, j = 0, k = 0;
  int[] mergedArray = new int[nums1.Length + nums2.Length];

  while (i < nums1.Length && j < nums2.Length) {
    if (nums1[i] < nums2[j]) mergedArray[k++] = nums1[i++];
    else mergedArray[k++] = nums2[j++];
  }
  while (i < nums1.Length) mergedArray[k++] = nums1[i++];
  while (j < nums2.Length) mergedArray[k++] = nums2[j++];

  int length = mergedArray.Length - 1;

  return mergedArray.Length % 2 == 0 
  ? (double)(mergedArray[length / 2] + mergedArray[(length / 2) + 1]) / 2 
  : mergedArray[length / 2];
}`;
export const ZIGZAG_CONVERSION_SNIPPET = `public static string Convert(string s, int numRows) {
  var dict = new Dictionary < int, string > ();
  bool flag = false;

  for (int i = 0, j = 0; i < s.Length; i++) {
    if (!dict.ContainsKey(j)) dict.Add(j, s[i].ToString());
    else dict[j] += s[i].ToString();

    if (j == numRows - 1) flag = true;
    if (j == 0) flag = false;

    j = flag ? j - 1 : j + 1;
  }

  return string.Join("", dict.Values);
}`;
export const TWO_SUM_SNIPPET = `public static int[] FindTwoSum(int[] nums, int target) {
  var dictionary = new Dictionary < int, int > ();

  for (int i = 0; i < nums.Length; i++) {
    if (dictionary.ContainsKey(target - nums[i]))
      return new int[] {
        dictionary[target - nums[i]], i
      };

    if (!dictionary.ContainsKey(nums[i]))
      dictionary.Add(nums[i], i);
  }

  return null;
}`;
export const THREE_SUM_SNIPPET = `public static IList < IList < int >> FindThreeSum(int[] nums) {
  Array.Sort(nums);

  var result = new List < IList < int >> ();

  if (nums[0] > 0) return result;

  for (int i = 0; i < nums.Length - 2; i++) {
    if (nums[i] > 0) break;
    if (i > 0 && nums[i] == nums[i - 1]) continue;

    int left = i + 1;
    int right = nums.Length - 1;

    while (left < right) {
      int sum = nums[i] + nums[left] + nums[right];

      if (sum == 0) {
        result.Add(new List < int > {
          nums[i],
          nums[left],
          nums[right]
        });

        while (left < right && nums[left] == nums[left + 1]) left++;
        while (left < right && nums[right] == nums[right - 1]) right--;

        left++;
        right--;
      } else if (sum < 0) left++;
      else right--;
    }
  }

  return result;
}`;
export const STRING_TO_INTEGER_ATOI_SNIPPET = `public static int MyAtoi(string s) {
  if (s == string.Empty || s[0] == '.') return 0;

  string result = string.Empty;
  bool isNegative = false;
  int i = 0;

  while (i < s.Length && s[i] == ' ') i++;

  if (i < s.Length && (s[i] == '-' || s[i] == '+')) {
    isNegative = s[i] == '-';
    i++;
  }

  while (i < s.Length && char.IsDigit(s[i])) {
    result += s[i].ToString();
    i++;
  }

  result = result.TrimStart('0');

  if (result.Length == 0) return 0;
  if (int.TryParse(result, out int value)) return isNegative ? value * -1 : value;
  return isNegative ? int.MinValue : int.MaxValue;
}`;
export const REMOVE_NTH_NODE_FROM_END_OF_LIST_SNIPPET = `public static ListNode? RemoveNthFromEnd(ListNode head, int n) {
  int length = 0, pos = 1;
  ListNode p = head;

  while (p != null) {
    length++;
    p = p.next;
  }

  if (length == 1) return null;

  p = head;

  while (p != null) {
    if (pos == length - n) {
      p.next = p.next.next;
      break;
    }

    if (pos > length - n) {
      head = p.next;
      break;
    }

    pos++;
    p = p.next;
  }

  return head;
}`;
export const VALID_PARENTHESES_SNIPPET = `public static bool IsValid(string s) {
  var stack = new Stack < char > ();
  var dictionary = new Dictionary < char, char > () 
  {
    { '(', ')' },
    { '[', ']' },
    { '{', '}' }
  };

  foreach(char character in s) {
    if (dictionary.ContainsKey(character)) stack.Push(dictionary[character]);
    else if (stack.Count == 0 || character != stack.Pop()) return false;
  }

  return stack.Count == 0;
}`;
export const FIND_DISAPPEARED_NUMBERS_SNIPPET = `public static IList<int> FindDisappearedNumbers(int[] nums)
{
    var range = nums.Length;
    var result = new HashSet<int>();
    var numsSet = new HashSet<int>(nums);

    for (var i = 1; i <= range; i++)
    {
        if (!numsSet.Contains(i)) result.Add(i);
    }

    return [.. result];
}`
export const LETTER_COMBINATIONS_OF_A_PHONE_NUMBER_SNIPPET = `public static class LetterCombinationsOfAPhoneNumber
{
    private static readonly Dictionary<char, string> PhoneLetterCombinations = new()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    public static IList<string> LetterCombinations(string digits)
    { 
        var result = new List<string>();

        if (string.IsNullOrEmpty(digits)) return result;

        BuildCombinations(digits, 0, string.Empty, result);

        return result;
    }

    private static void BuildCombinations(string digits, int index, string current, IList<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(current);
            return;
        }

        foreach (var letter in PhoneLetterCombinations[digits[index]])
        {
            BuildCombinations(digits, index + 1, current + letter, result);
        }
    }
}`
export const DIVIDE_TWO_INTEGERS_SNIPPET = `public static class DivideTwoIntegers
{
    public static int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        if (divisor == 1) return dividend;
        if (divisor == -1) return -dividend;

        long castDivident = Math.Abs((long)dividend);
        long castDivisor = Math.Abs((long)divisor);
        bool isNegative = (dividend < 0) ^ (divisor < 0);
        long result = 0;        
        
        
        while(castDivident >= castDivisor)  
        {
            castDivident -= castDivisor;
            result++;
        }

        return (int)(result * (isNegative ? -1 : 1));
    }
}`