public class Solution {
    private Dictionary<char, int> romanToValue = new Dictionary<char, int>(); 
    public Solution(){
        romanToValue.Add('I', 1);
        romanToValue.Add('V', 5);
        romanToValue.Add('X', 10);
        romanToValue.Add('L', 50);
        romanToValue.Add('C', 100);
        romanToValue.Add('D', 500);
        romanToValue.Add('M', 1000);
    }

    public int RomanToInt(string s) {
        int result = 0;
        int i = 0;
        while(i < s.Length){
            if(i != s.Length -1){
                if(romanToValue[s[i+1]] >romanToValue[s[i]]){
                    result += romanToValue[s[i+1]] - romanToValue[s[i]];
                    i+=2;
                    continue;
                }
            }
            result += romanToValue[s[i]];
            i++;
           
        }
        
        return result; 
    }
}