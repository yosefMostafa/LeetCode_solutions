public class Solution {
    private string t ="";
    public bool CanConstruct(string ransomNote, string magazine) {
       t = magazine;
     
        foreach(char c in ransomNote )
        {
            if(!hasChar(c)){
                return false;
            }
        }
        return true;
    }
private bool hasChar(char c)
{
for(int j = 0 ;j < t.Length; j++  )
    {
        if(t[j] == c)
        {
            t = t.Remove( j, 1);
            return true;
        }
    }
    return false;
}
    
}