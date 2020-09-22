int commonCharacterCount(string s1, string s2) {
    int count = 0;
    StringBuilder sb = new StringBuilder();
    sb.Append(s2);
            
    foreach(var ch in s1)
    {
        if (sb.ToString().Contains(ch))
        {
            int startIndex = sb.ToString().IndexOf(ch);
            sb = sb.Remove(startIndex, 1);
            count++;
        }
    }
    
    return count;
}
