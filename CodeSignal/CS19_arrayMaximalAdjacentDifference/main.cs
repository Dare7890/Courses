int arrayMaximalAdjacentDifference(int[] inputArray) {
            int maxDifferent = 0;
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                int different = Math.Max(Math.Abs(inputArray[i] - inputArray[i - 1]),
                    Math.Abs(inputArray[i] - inputArray[i + 1]));
                if (different > maxDifferent)
                    maxDifferent = different;
            }
            return maxDifferent;
}
