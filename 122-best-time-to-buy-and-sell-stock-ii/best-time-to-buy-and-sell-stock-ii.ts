function maxProfit(prices: number[]): number {
    let totaProfit: number = 0;
    for (let i = 1; i < prices.length; i++) {
        // let price: number = prices[i]
        // let prvPrice: number = prices[i - 1]

        if (prices[i] -  prices[i - 1] > 0) {
            totaProfit += prices[i] -  prices[i - 1];
        }

    }

    return totaProfit;
};