string alphabeticShift(string inputString) {
    string result = "";
            foreach (byte item in inputString.ToCharArray().Select(i => i + 1))
            {
                // if (item == 123)
                //     result += (char)97;
                // else
                //     result += (char)item;
                if (item == 123)
                    result += Encoding.ASCII.GetChars(new byte[] { 97})[0];
                else
                    result += Encoding.ASCII.GetChars(new byte[] { item})[0];
            }
            return result;
}