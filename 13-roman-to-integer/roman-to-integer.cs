public class Solution {

    private Dictionary<char, int> getRomansDic(){
        Dictionary<char, int> romanToValue = new Dictionary<char, int>();
         romanToValue.Add('I', 1);
        romanToValue.Add('V', 5);
        romanToValue.Add('X', 10);
        romanToValue.Add('L', 50);
        romanToValue.Add('C', 100);
        romanToValue.Add('D', 500);
        romanToValue.Add('M', 1000);
        return romanToValue;

    }

    public int RomanToInt(string s) {
        int result = 0;
        int i = 0;
        Dictionary<char, int> romanToValue = getRomansDic();
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
        romanToValue.Clear();
        return result; 
    }
}