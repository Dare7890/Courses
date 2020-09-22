bool isLucky(int n) {
    string text = n.ToString();
            bool result = default;
            int[] array = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = Convert.ToInt32(text[i].ToString());
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > array.Length / 2 - 1)
                {
                    sum1 += array[i];
                }
                else
                {
                    sum2 += array[i];
                }
            }
                return result = (sum1 == sum2) ? true : false;
}
