function hIndex(citations: number[]): number {
    let hIndex:number = 0;
    citations.sort(function(a, b){return b-a})
    let maxIndex = citations.length
    console.log(citations)
    for (let index :number = 0;index < maxIndex;index++){
           
        if(citations[index] > hIndex){
            hIndex = index +1
        }
         console.log(hIndex)
    }
     console.log(hIndex)
    return hIndex;
};