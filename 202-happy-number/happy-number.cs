public class Solution {
    public bool IsHappy(int n) {
        string InitialNum = n.ToString();
        HashSet<int> seen = new HashSet<int>();
        while(true){
        
        int sum = 0;
        for (int i = 0 ;i< InitialNum.Length;i++){
            int num = int.Parse(InitialNum[i].ToString());
            sum += num * num;
        }
        if(sum == 1)
            return true; 
        if(!seen.Add(sum))
            return false;
       
        InitialNum = sum.ToString();
        }
       
    }
}