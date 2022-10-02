// Given a string s which consists of lowercase or uppercase letters, 
// return the length of the longest palindrome that can be built with those letters.

// Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

// Example 1:

// Input: s = "abccccdd"
// Output: 7
// Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.

public class Blind75Questions
{  
    public int LongestPalindrome(string s) {
        if(s==null || s.Length==0) return 0;
        List<Char> list = new List<Char>();
        int count = 0;
        for(int i=0; i<s.Length; i++){
            if(list.Contains(s[i]))
            {
                list.Remove(s[i]);
                count++;
            }
            else
            {
                list.Add(s[i]);
            }
        }
        if(list.Count != 0) {
            return count*2+1;
        }
        return count*2; 
    }

    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      string str = "abccddee";

      int length = obj.LongestPalindrome(str);
      Console.WriteLine("Length of the longest palindrome that can be built is:" + length);
    }
}
