string reverseInParentheses(string inputString) {
        string[] arrayOfStr = inputString.Split('(', ')');

            foreach (string s in arrayOfStr)
            {
                char[] arrayOfChar = s.ToCharArray();
                Array.Reverse(arrayOfChar);
                inputString = inputString.Replace($"({s})", new string(arrayOfChar));
            }

            if (inputString.Contains("("))
            {
                return reverseInParentheses(inputString);
            }
            return inputString;
}
