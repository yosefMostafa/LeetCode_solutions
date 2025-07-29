public class Solution {
    public bool IsHappy(int n) {
        string InitialNum = n.ToString();
        List<int> seen = [];
        while(true){
        
        int sum = 0;
        for (int i = 0 ;i< InitialNum.Length;i++){
            int num = int.Parse(InitialNum[i].ToString());
            sum += num * num;
        }
      
      
        if(seen.Contains(sum) && seen.Count > 1  )
            return false;
        if(sum == 1)
            return true; 
        seen.Add(sum);
        InitialNum = sum.ToString();
        }
       
    }
}