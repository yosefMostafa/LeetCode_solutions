function jump(nums: number[]): number {
  let pos: number = 0;
  let jumps: number = 0;
  const path: number[] = [0];
  if(nums.length <= 1  ){
    return 0;
  }
  if(nums[0] >= nums.length -1 ){
    return 1;
  }
  while (pos < nums.length - 1) {
    let farthest: number = pos;
    let nextPos: number = pos;
    if(farthest + nums[pos] >= nums.length -1){
       pos = nums.length;
        jumps++;
        continue;
    }
    // Find the position that can reach farthest within current jump range
    for (let i = pos + 1; i <= Math.min(pos + nums[pos], nums.length - 1); i++) {
      if (i + nums[i] > farthest) {
        
        farthest = i + nums[i];
        nextPos = i;
      }
    }
    
    pos = nextPos;
    jumps++;
    path.push(pos);
  }
  return jumps;
};