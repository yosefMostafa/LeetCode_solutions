public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> output = new List<string>();
        if(nums.Length == 0)
            return output;
        else if(nums.Length == 1){
            output.Add(nums[0].ToString());
            return output;
        }
        
        int initialNum = nums[0];
        int prevNum = nums[0];
        for(int i = 1 ;i <nums.Length  ;i++){
            if(SafeAbs(nums[i] - prevNum) > 1 ){
                if(initialNum == prevNum )
                    output.Add(initialNum.ToString());
                else
                    output.Add(initialNum.ToString()+ "->" + prevNum.ToString());
                initialNum = nums[i];
            }
            prevNum = nums[i];
        }
        if(initialNum == prevNum )
            output.Add(initialNum.ToString());
        else
            output.Add(initialNum.ToString()+ "->" + prevNum.ToString());
        return output;
    }
    private  static long SafeAbs(int value)
{
    if (value == int.MinValue)
        return (long)int.MaxValue + 1; // 2147483648 as long
    return Math.Abs(value);
}
}