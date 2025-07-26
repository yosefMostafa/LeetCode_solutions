public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        int[] sCharCount = getCharCount(s);
        // int[] tCharCount = getCharCount(t);
        int[] charCount = new int[26];
        foreach(char i in t){
             charCount[i - 'a']++;
            if(sCharCount[i - 'a'] == 0 || charCount[i - 'a'] > sCharCount[i - 'a'])
                return false;
             
               
        } 
        return true;
        
    }
    private int[] getCharCount(string word){
        int[] charCount = new int[26];
        foreach(char i in word){
            charCount[i - 'a'] ++;
        }
        return charCount;
    } 
}