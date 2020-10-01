int[][] boxBlur(int[][] image) {
            int[][] result = new int[image.Length - 2][];
            for (int i = 0; i < image.Length - 2; i++)
            {
                result[i] = new int[image[i].Length - 2];
            }
            int countI = 0;
            int countJ = 0;
            for (int k = 0; k < ((image.Length - 2) * (image[0].Length - 2)); k++)
            {
                int countINewArray = 0;
                int[][] newArray = new int[3][];
                for (int i = countI; i < countI + 3; i++)
                {
                    int countJNewArray = 0;
                    newArray[countINewArray] = new int[3];
                    for (int j = countJ; j < countJ + 3; j++)
                    {
                        newArray[countINewArray][countJNewArray] = image[i][j];
                        countJNewArray++;
                    }
                    countINewArray++;
                }
                int avgNumber = AvgNumber(newArray);
                result[countI][countJ] = avgNumber;
                if ((countJ + 2) == image[0].Length - 1)
                {
                    countI++;
                    countJ = 0;
                }
                else
                    countJ++;
            }
            return result;
}

static int AvgNumber(int[][] array)
        {
            int avgSum = 0;
            foreach (var item in array)
                foreach (var i in item)
                    avgSum += i;
            avgSum /= (array.GetLength(0) * array.Length);
            return avgSum;
        }
