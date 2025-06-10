function hIndex(citations: number[]): number {
    let hIndex:number = 0;
    citations.sort(function(a, b){return b-a})
    for (let index :number = 0;index < citations.length;index++){   
        if(citations[index] > hIndex){
            hIndex = index +1
        }
    }
    return hIndex;
};