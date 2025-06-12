class RandomizedSet {
    private valToIndex: Map<number, number>;
    private values: number[];
    private length :number;

    constructor() {
        this.valToIndex = new Map();
        this.values = [];
        this.length = 0;
    }

    insert(val: number): boolean {
        if (this.valToIndex.has(val)) return false;

        this.values.push(val);
        this.length++;
        this.valToIndex.set(val, this.length - 1);
        return true;
    }

    remove(val: number): boolean {
        if (!this.valToIndex.has(val)) return false;

        const indexToRemove = this.valToIndex.get(val)!;
        const lastElement = this.values[this.length - 1];

        this.values[indexToRemove] = lastElement;
        this.valToIndex.set(lastElement, indexToRemove);

        this.values.pop();
        this.length --;
        this.valToIndex.delete(val);

        return true;
    }

    getRandom(): number {
        return this.values[Math.floor(Math.random() *this.length)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * var obj = new RandomizedSet()
 * var param_1 = obj.insert(val)
 * var param_2 = obj.remove(val)
 * var param_3 = obj.getRandom()
 */