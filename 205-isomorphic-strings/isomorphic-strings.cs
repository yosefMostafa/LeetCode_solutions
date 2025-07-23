public class Solution {
    public bool IsIsomorphic(string s, string t) {
      
    Dictionary<char, char> mapST = new Dictionary<char, char>();
    HashSet<char> mappedValues = new HashSet<char>();

    for (int i = 0; i < s.Length; i++)
    {
        char c1 = s[i];
        char c2 = t[i];

        if (mapST.ContainsKey(c1))
        {
            if (mapST[c1] != c2)
                return false; // Mismatch
        }
        else
        {
            if (mappedValues.Contains(c2))
                return false; // c2 is already mapped to another character

            mapST[c1] = c2;
            mappedValues.Add(c2);
        }
    }

    return true;

    }
}