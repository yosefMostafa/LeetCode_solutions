using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        Regex rgx = new Regex("[^a-z0-9]");
        s = rgx.Replace(s, "");
        int strtingLength = s.Length;
        for(int i = 0 ;i < strtingLength ; i++){
            if(s[i] != s[strtingLength - i -1]){
                return false;
            }
        }
        return true;
    }
}