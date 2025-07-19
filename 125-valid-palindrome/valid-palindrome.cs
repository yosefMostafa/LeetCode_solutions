using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        Regex rgx = new Regex("[^a-z0-9]");
        s = rgx.Replace(s, "");
        int j = s.Length -1;
        for(int i = 0 ;i < s.Length ; i++){
            if(s[i] != s[j - i]){
                return false;
            }
        }
        return true;
    }
}