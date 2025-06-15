function canCompleteCircuit(gas: number[], cost: number[]): number {
    let totalTank = 0;
    let currTank = 0;
    let startIndex = 0;

    for (let i = 0; i < gas.length; i++) {
        const diff = gas[i] - cost[i];
        totalTank += diff;
        currTank += diff;

        if (currTank < 0) {
            currTank = 0;
            startIndex = i + 1;
        }
    }

    return totalTank >= 0 ? startIndex : -1;
};