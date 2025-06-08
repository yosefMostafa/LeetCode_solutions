/**
 Do not return anything, modify nums in-place instead.
 */
function rotate(nums: number[], k: number): void {
    let temp:number[] = [...nums]
  for(let index:number = 0;index<nums.length;index++){
    nums[(index+k)% nums.length] = temp[index]
  }  
};