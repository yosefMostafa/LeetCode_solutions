function maxProfit(prices: number[]): number {
 let minPrice = Infinity;
    let maxProfit = 0;

    for (let price of prices) {
        if (price < minPrice) {
            minPrice = price; // Update the lowest price so far
        } else {
            const profit = price - minPrice;
            if (profit > maxProfit) {
                maxProfit = profit; // Update max profit if it's better
            }
        }
    }

    return maxProfit;
};