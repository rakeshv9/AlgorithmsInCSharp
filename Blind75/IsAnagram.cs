// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or 
// phrase, typically using all the original letters exactly once.

// Example 1:

// Input: s = "anagram", t = "nagaram"
// Output: true
// Example 2:

// Input: s = "rat", t = "car"
// Output: false

public class Blind75Questions
{  
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        int[] freq = new int[26];
        for(int i=0; i< s.Length; i++){
            freq[s[i] - 'a']++;
        }

        for(int j=0; j< t.Length; j++){
            freq[t[j]-'a']--;
            if(freq[t[j]-'a'] < 0){
                return false;
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      string str1 = "bat";
      string str2 = "tab";

      bool isAnagram = obj.IsAnagram(str1, str2);
      Console.WriteLine("Given strings are Anagram:" +isAnagram);
    }
}
