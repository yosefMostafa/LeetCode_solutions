public class Solution {
    // public bool IsHappy(int n) {
    //     string InitialNum = n.ToString();
    //     HashSet<int> seen = new HashSet<int>();
    //     while(true){
        
    //     int sum = 0;
    //     for (int i = 0 ;i< InitialNum.Length;i++){
    //         int num = int.Parse(InitialNum[i].ToString());
    //         sum += num * num;
    //     }
    //     if(sum == 1)
    //         return true; 
    //     if(!seen.Add(sum))
    //         return false;
       
    //     InitialNum = sum.ToString();
    //     }
       
    // }
    private int GetSumOfSquares(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        sum += digit * digit;
        n /= 10;
    }
    return sum;
}

public bool IsHappy(int n)
{
    int slow = n;
    int fast = GetSumOfSquares(n);

    while (fast != 1 && slow != fast)
    {
        slow = GetSumOfSquares(slow);             // move 1 step
        fast = GetSumOfSquares(GetSumOfSquares(fast)); // move 2 steps
    }

    return fast == 1;
}
}