bool areSimilar(int[] a, int[] b) {
bool isFalse = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i] && isFalse == false)
                {
                    isFalse = true;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (b[.ElementAt(i)] == a.ElementAt(j))
                        {
                            
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                            break;
                        }
                    }
                }
                if (a[i] != b[i] && isFalse == true)
                {
                    return false;
                }
            }
            return true;
}
