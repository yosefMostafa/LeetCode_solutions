public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
     Dictionary<int, int> foundValues = new  Dictionary<int,int>();
     for(int i =0;i < nums.Length; i++){
        if(foundValues.ContainsKey(nums[i]))
            if(i - foundValues[nums[i]] <= k)
                return true;
            foundValues[nums[i]] = i;
     }
       
     return false;
    }
}