int adjacentElementsProduct(int[] inputArray) {
    int maxMult = -1000;
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        if (inputArray[i] * inputArray[i + 1] > maxMult)
            maxMult = inputArray[i] * inputArray[i + 1];
    }
    return maxMult;
}