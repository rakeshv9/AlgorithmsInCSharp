// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and 
// removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric 
// characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

// Example 1:

// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.

public class Blind75Questions
{  
    public bool IsPalindrome(string s) {
        if(s == null || s.Length == 0){
            return false;
        }
        int start = 0, end = s.Length - 1;
        while(start < end){
            if(!Char.IsLetterOrDigit(s[start])){
                start++;
            }
            else if(!Char.IsLetterOrDigit(s[end])){
                end--;
            }
            else{
            if(Char.ToLower(s[start]) != Char.ToLower(s[end])){
                return false;
            }
            start++;
            end--;
            }

        }
        return true;
    }

    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      string input = "A man, a plan, a canal: Panama";
      bool isPalindrome = obj.IsPalindrome(input);
      Console.WriteLine("Given string is palindrome:" +isPalindrome);
    }
}
