int depositProfit(int deposit, int rate, int threshold) {
    double doubleDeposite = deposit;
    int countOfYear = 0;
    while(doubleDeposite < threshold)
    {
        doubleDeposite *= (1.0 + rate / 100.0);
        countOfYear++;
    }
    return countOfYear;
}
