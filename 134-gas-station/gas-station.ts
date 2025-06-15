function canCompleteCircuit(gas: number[], cost: number[]): number {
    let sumGas : number = 0;
    let sumCost :number =0 ;
    for(let i:number = 0;i<gas.length;i++){
        sumGas +=gas[i]
        sumCost += cost[i]
    }
    if(sumGas < sumCost){
        return -1;
    }    
    let startingStationIndex : number  = -1;
    let carTank : number = 0;
    let path:number[] = [];
    for(let i:number = 0;i<gas.length;i++){
        carTank += gas[i]
        let remainigGasAfterTravel :number = carTank - cost[i]
            console.log(remainigGasAfterTravel)

        if(remainigGasAfterTravel >= 0){
            carTank = remainigGasAfterTravel
           path.push(i)
        }else{
            carTank = 0
            path=[]
        }
    }
    console.log(path)
    if(path){
        return path[0] 
    }else{
        return -1
    }
};