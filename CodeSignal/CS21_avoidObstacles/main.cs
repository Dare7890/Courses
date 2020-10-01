int avoidObstacles(int[] inputArray) {
            int iteration = 1;
            while (!Jump(iteration, inputArray))
                iteration++;
            return iteration;
}

static bool Jump(int number, int[] inputArray)
        {
            int startPoint = 0;
            Array.Sort(inputArray);
            while (startPoint < inputArray.Last())
            {
                startPoint += number;
                if (inputArray.Contains(startPoint))
                    return false;
            }
            return true;
        }