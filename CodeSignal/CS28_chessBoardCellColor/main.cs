bool chessBoardCellColor(string cell1, string cell2) {
    int[,] borderChess = new int[8, 8];
            Chess letterCell1 = (Chess)Enum.Parse(typeof(Chess), cell1[0].ToString());
            int numberCell1 = int.Parse(cell1[1].ToString()) - 1;
            Chess letterCell2 = (Chess)Enum.Parse(typeof(Chess), cell2[0].ToString());
            int numberCell2 = int.Parse(cell2[1].ToString()) - 1;
            for (int i = 0; i < borderChess.GetLength(0); i++)
            {
                for (int j = 0; j < borderChess.GetLength(1); j++)
                {
                    borderChess[i, j] = (i + j) % 2 == 0 ? 0 : 1;
                }
            }

            for (int i = 0; i < borderChess.Length; i++)
            {
                for (int j = 0; j < borderChess.GetLength(1); j++)
                {
                    if (borderChess[(int)letterCell1, numberCell1] == borderChess[(int)letterCell2,
                        numberCell2])
                        return true;
                    else
                        return false;
                }
            }
            return true;
}

enum Chess
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
        }
