function canCompleteCircuit(gas: number[], cost: number[]): number {
    let sumGas : number = 0;
    let sumCost :number =0 ;
    // for(let i:number = 0;i<gas.length;i++){
    //     sumGas +=gas[i]
    //     sumCost += cost[i]
    // }
    // if(sumGas < sumCost){
    //     return -1;
    // }    
    let carTank : number = 0;
    let path:number[] = [];
    for(let i:number = 0;i<gas.length;i++){
        carTank += gas[i]
        carTank = carTank - cost[i]
             sumGas +=gas[i]
        sumCost += cost[i]
        if(carTank >= 0){
           path.push(i)
        }else{
            carTank = 0
            path=[]
        }
    }
  if(sumGas < sumCost){
        return -1;
    }   
    if(path .length > 0){
        return path[0] 
    }else{
        return -1
    }
};