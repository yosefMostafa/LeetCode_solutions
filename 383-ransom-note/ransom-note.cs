public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
     
       int[] letters = new int[26]; // for 'a' to 'z'

    foreach (char c in magazine)
    {
        letters[c - 'a']++;
    }

    foreach (char c in ransomNote)
    {
        if (letters[c - 'a'] == 0)
            return false;
        letters[c - 'a']--;
    }

    return true;
    }


    
}