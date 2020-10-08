int circleOfNumbers(int n, int firstNumber) {
        int steps = n / 2;
        for (int i = 0; i < steps; i++)
        {
            firstNumber++;
            if (firstNumber == n)
                firstNumber = 0;
        }
        return firstNumber;
}