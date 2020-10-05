int[][] minesweeper(bool[][] matrix) {
    int[][] result = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new int[matrix[0].Length];
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    int amountOfMines = AmountOfMines(matrix, i, j);
                    result[i][j] = amountOfMines;
                }
            }
            return result;
}

static int AmountOfMines(bool[][] matrix, int coordI, int coordJ)
        {
            int amountOfMines = 0;
            for (int i = coordI - 1; i < coordI + 2; i++)
            {
                for (int j = coordJ - 1; j < coordJ + 2; j++)
                {
                    try
                    {
                        if (matrix[i][j] == true && (i != coordI || j != coordJ))
                            amountOfMines++;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            return amountOfMines;
        }
