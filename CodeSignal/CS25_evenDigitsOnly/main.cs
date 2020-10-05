bool evenDigitsOnly(int n) {
    bool result = true;
            while (n > 0)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 10;
            }
            return result;
}
