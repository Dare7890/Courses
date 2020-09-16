bool checkPalindrome(string inputString) {
    char[] arrayOfCharacters = inputString.ToCharArray();
    bool isPalindrome = default;
    if (arrayOfCharacters.Length == 1){
        return true;
    }
            if (arrayOfCharacters[0] == arrayOfCharacters[arrayOfCharacters.Length - 1])
            {
                for (int i = 0; i < arrayOfCharacters.Length / 2 - 1; i++)
                {
                    if (arrayOfCharacters[i + 1] != arrayOfCharacters[arrayOfCharacters.Length - 2 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                    else
                    {
                        isPalindrome = true;
                    }
                }
            }
            return isPalindrome;
}