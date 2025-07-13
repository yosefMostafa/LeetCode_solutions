public class Solution {
    private int bIndex = 0;
    private int endBIndex = -1;
    private int totalWaterTrapped = 0;

    public int Trap(int[] height) {
       int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        int waterTrapped = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                    leftMax = height[left];
                else
                    waterTrapped += leftMax - height[left];
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                    rightMax = height[right];
                else
                    waterTrapped += rightMax - height[right];
                right--;
            }
        }

        return waterTrapped;
    }
  
}
//block hieght 
//block index 
//block water amount 
//block has end 
//block has another similar end 