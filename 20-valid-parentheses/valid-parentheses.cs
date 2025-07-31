public class Solution {
    public bool IsValid(string s) {
        Stack<char>  parenthesesOrder = new Stack<char>();
        Dictionary<char, char> relatedParentheses = new Dictionary<char, char>();
        relatedParentheses['{'] = '}';
        relatedParentheses['['] = ']';
        relatedParentheses['('] = ')';
        if(s.Length == 1)
            return false;
        foreach(char parentheses in s){
            if(parenthesesOrder.Count != 0 && relatedParentheses.ContainsValue(parentheses)){
                    char scope  = parenthesesOrder.Peek();
                    if(relatedParentheses[scope] == parentheses)
                        parenthesesOrder.Pop();
                    else
                        return false;
                    
            }else{
                if(relatedParentheses.ContainsValue(parentheses))
                    return false;
                parenthesesOrder.Push(parentheses);

            }
        }
        if(parenthesesOrder.Count == 0)
            return true;
        else 
            return false;
    }
}