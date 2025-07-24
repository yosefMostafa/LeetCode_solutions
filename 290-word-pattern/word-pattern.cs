public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words =  s.Split(" ");
        if(words.Count() != pattern.Length)
            return false;
        Dictionary<char, string> mapST = new Dictionary<char, string>();
        for(int i = 0; i< pattern.Length;i++){
            char key = pattern[i];
            string value = words[i];
            if(mapST.ContainsKey(key)){
                if(mapST[key] != value)
                    return false;
            }else{
                if(mapST.ContainsValue(value))
                    return  false;
                mapST[key] = value;
            }
        }
        return true;
    }
}