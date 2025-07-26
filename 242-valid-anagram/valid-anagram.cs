public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        int[] sCharCount = new int[26];
        foreach(char i in s){
            sCharCount[i - 'a'] ++;
        }
        int[] tcharCount = new int[26];
        foreach(char i in t){
            tcharCount[i - 'a']++;
            if(sCharCount[i - 'a'] == 0 || tcharCount[i - 'a'] > sCharCount[i - 'a'])
                return false;
               
        } 
        return true;
        
    }

}