public class Solution {
    public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length)
        return false;
    int[] charCount = new int[26]; // For 'a' to 'z'

    for (int i = 0; i < s.Length; i++)
    {
        charCount[s[i] - 'a']++;  // Increment for s
        charCount[t[i] - 'a']--;  // Decrement for t
    }

    foreach (int count in charCount)
    {
        if (count != 0)
            return false;
    }

    return true;
    }

}