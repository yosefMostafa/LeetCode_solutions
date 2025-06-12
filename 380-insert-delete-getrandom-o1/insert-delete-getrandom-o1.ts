class RandomizedSet {
    list:number[];
    length:number;
    constructor() {
        this.list  =[];
        this.length = 0;
    }
    v
    insert(val: number): boolean {
        for(let i:number =0;i<this.length;i++){
            if(this.list[i] === val){
                return false
            }
        }
        this.list[this.length++] = val
        return true;

    }
    printList():void{
        console.log(this.list)
    }
    remove(val: number): boolean {
          for(let i:number =0;i<this.length;i++){
            if(this.list[i] === val){
              this.list.splice(i,1)
              this.length --;
              return true
            }
        }
          return false;
    }

    getRandom(): number {
       const randIndex = Math.floor(Math.random() * this.length);
        return this.list[randIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * var obj = new RandomizedSet()
 * var param_1 = obj.insert(val)
 * var param_2 = obj.remove(val)
 * var param_3 = obj.getRandom()
 */