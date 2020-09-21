int matrixElementsSum(int[][] matrix) {
    int costOfTheRoom = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    costOfTheRoom += matrix[j][i];
                    if (matrix[j][i] == 0 )
                    {
                        break;
                    }
                }
            }
    return costOfTheRoom;
}