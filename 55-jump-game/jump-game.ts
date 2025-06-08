function canJump(nums: number[]): boolean {
   let farthest = 0;

    for (let i = 0; i < nums.length; i++) {
        if (i > farthest) {
            return false; // We've reached a point we can't get to
        }
        farthest = Math.max(farthest, i + nums[i]);
    }

    return true;

};
//  if(nums.length === 1 ){
//         return true;
//     }
//     for (let i = nums[0]; i >0; i--) {
//         let foundPath:boolean = canJump(nums.slice(i,nums.length))
//         if(foundPath){
//             return foundPath
//         }
//     }
//     return false