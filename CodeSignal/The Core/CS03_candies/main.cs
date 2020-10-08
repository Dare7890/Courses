int candies(int n, int m) {
    int countCandy = (n <= m) ? (m / n) * n : 0;
    return countCandy;
}
