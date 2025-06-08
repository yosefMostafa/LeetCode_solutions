function removeDuplicates(nums: number[]): number {
    if (nums.length === 0) return 0;

    let k = 1; // Start from index 1; first element is always unique
    let num = 1
    for (let i = 1; i < nums.length; i++) {

        if (nums[i] == nums[k - 1]) {
          if(num%2==1){
                nums[k] = nums[i];
                k++;
                num ++;
              }

        } else {
                nums[k] = nums[i];
                k++;
                num = 1
        }

    }

    return k;
};