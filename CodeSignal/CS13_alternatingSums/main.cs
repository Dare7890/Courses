int[] alternatingSums(int[] a) {
    var clearSequence = a.Where((el, pos) => pos % 2 == 0).ToArray();
    var oddSequence = a.Where((el, pos) => pos % 2 != 0).ToArray();
    int sum1 = SumOfNumbers(clearSequence);
    int sum2 = SumOfNumbers(oddSequence);
    int[] result = {sum1, sum2};
    return result;
}

int SumOfNumbers (int[] total){
        int sum = 0;
            foreach (var item in total)
                sum += item;
            return sum;
}