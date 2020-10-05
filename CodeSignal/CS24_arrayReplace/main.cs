int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem) {
    if (inputArray.Contains(elemToReplace))
            {
                foreach (var item in inputArray.Where(el => el ==
            elemToReplace))
                {
                    int index = Array.IndexOf(inputArray, item);
                    inputArray[index] = substitutionElem;
                }
            }
            return inputArray;
}
