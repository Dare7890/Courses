bool isIPv4Address(string inputString) {
            string pattern = @"^((0|2[0-4][0-9]|1([0-9]){0,2}|25([0-5]){0,1}).){3}(0|2[0-4][0-9]|1([0-9]){0,2}|25([0-5]{0,1}))$";
            if (Regex.IsMatch(inputString, pattern))
                return true;
            else
                return false;
}