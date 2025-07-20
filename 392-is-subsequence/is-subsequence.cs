public class Solution {
    private int lastIndex = -1;
    public bool IsSubsequence(string s, string t) {        
        foreach(char c in s )
        {
            if(!hasChar(c,t)){
                return false;
            }
        }
        return true;
    }
private bool hasChar(char c,string t)
{
for(int j = lastIndex + 1;j < t.Length; j++  )
    {
        if(t[j] == c)
        {
            lastIndex = j;
            return true;
        }
    }
    return false;
}
}