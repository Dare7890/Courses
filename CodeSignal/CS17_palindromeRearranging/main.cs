bool palindromeRearranging(string inputString) {
            bool oneNonepeatingValue = false;

            int[] array = new int[inputString.Distinct().Count()];
            for (int i = 0; i < inputString.Distinct().Count(); i++)
            {
                array[i] = inputString.Where(el => el ==
                inputString.Distinct().ElementAt(i)).Count();
            }
            foreach (var item in array)
            {
                if (item % 2 != 0)
                    if (oneNonepeatingValue == false)
                        oneNonepeatingValue = true;
                    else
                        return false;
            }
            return true;
}
