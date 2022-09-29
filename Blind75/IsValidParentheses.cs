// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.
 
// Example 1:
// Input: s = "()"
// Output: true
// Example 2:

// Input: s = "()[]{}"
// Output: true

public class Blind75Questions
{  
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
       foreach(char ch in s.ToArray()){
           if(ch == '('){
               stack.Push(')'); //push the corresponding closed bracket everytime you see an open bracket
           }
           else if(ch == '{'){
               stack.Push('}'); //same goes for "{"
           }
           else if(ch == '['){
               stack.Push(']'); //same for "["
           }
           ////if you encounter a closed bracket, and the stack is empty or the popped element is not same as 
           //the current character, that means it's an invalid Parentheses, we can immediately return false
   
           else if(stack.Count == 0 || stack.Pop() != ch) 
                       return false;
       } 
       //at the end return whether stack is empty or not
        return stack.Count == 0; 
    }
   
    public static void Main(string[] args)
    {
        string inputString = "()[]{}";
        Blind75Questions obj = new Blind75Questions();

        bool result = obj.IsValid(inputString);
        Console.WriteLine("The given input string contains valid parentheses: " +result);
    }   
}
