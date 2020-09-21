string[] allLongestStrings(string[] inputArray) {
    var MaxLengthOfElementsInArray = inputArray.Max(a => a.Length);
    var allLongestStrings = inputArray.Where(a => a.Length == 
    MaxLengthOfElementsInArray).ToArray();
    return allLongestStrings;
}
