bool almostIncreasingSequence(int[] sequence)
{
    bool oneExeption = false;
    bool increasingSequence = true;
    List<int> list = new List<int>();
    foreach (var item in sequence)
    {
        list.Add(item);
    }
    for (int i = 0; i < list.Count - 1; i++)
    {
        if (list.ElementAt(i) >= list.ElementAt(i + 1))
        {
            if (oneExeption == false)
            {
                oneExeption = true;
                if (list.Where(x => x == list.ElementAt(i)).Count() > 1 ||
                (list.Where(x => x == list.ElementAt(i + 1)).Count() < 2 &&
                list.ElementAt(i) > list.ElementAt(i + 1)))
                {
                    list.RemoveAt(i);
                }
                else
                {
                    list.RemoveAt(i + 1);
                }
                i = -1; //Удаление одного элемента и анализ массива с начала 
            }
            else if (oneExeption == true)
            {
                increasingSequence = false;
                return increasingSequence;
            }
        }
    }
    return increasingSequence;
}
