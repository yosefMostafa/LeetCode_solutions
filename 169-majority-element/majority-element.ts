function majorityElement(nums: number[]): number {
let maj:number = 0;
let counter : number =0
for (let index:number = 0;index<nums.length;index++){
    if(maj===nums[index]){
        counter++;
    }else if(counter === 0){
        maj = nums[index]
    }else{
        counter--;
    }
}
return maj;
};