function maxProfit(prices: number[]): number {
    let totaProfit: number = 0;
    for (let i = 1; i < prices.length; i++) {
        // let price: number = prices[i]
        // let prvPrice: number = prices[i - 1]
        const profit =  prices[i] -  prices[i - 1];
        if (profit > 0) {
            totaProfit += profit;
        }

    }

    return totaProfit;
};