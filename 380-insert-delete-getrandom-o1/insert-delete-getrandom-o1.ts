class RandomizedSet {
    private valToIndex: Map<number, number>;
    private values: number[];

    constructor() {
        this.valToIndex = new Map();
        this.values = [];
    }

    insert(val: number): boolean {
        if (this.valToIndex.has(val)) return false;

        this.values.push(val);
        this.valToIndex.set(val, this.values.length - 1);
        return true;
    }

    remove(val: number): boolean {
        if (!this.valToIndex.has(val)) return false;

        const indexToRemove = this.valToIndex.get(val)!;
        const lastElement = this.values[this.values.length - 1];

        this.values[indexToRemove] = lastElement;
        this.valToIndex.set(lastElement, indexToRemove);

        this.values.pop();
        this.valToIndex.delete(val);

        return true;
    }

    getRandom(): number {
        const randIndex = Math.floor(Math.random() * this.values.length);
        return this.values[randIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * var obj = new RandomizedSet()
 * var param_1 = obj.insert(val)
 * var param_2 = obj.remove(val)
 * var param_3 = obj.getRandom()
 */