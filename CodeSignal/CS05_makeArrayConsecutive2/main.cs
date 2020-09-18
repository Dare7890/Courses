int makeArrayConsecutive2(int[] statues) {
    Array.Sort(statues);
            int countAdditionalStatues = 0;
            for (int i = statues.First(); i < statues.Last(); i++)
            {
                if (!statues.Contains(i))
                {
                    countAdditionalStatues++;
                }
            }
    return countAdditionalStatues;
}