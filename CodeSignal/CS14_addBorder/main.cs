string[] addBorder(string[] picture) {
List<string> newString = new List<string>();
            var countOfStars = picture.Max(s => s.Length);
            newString.Add(LineOfStars(countOfStars));
            foreach (var item in picture)
            {
                newString.Add("*" + item + "*");
            }
            newString.Add(LineOfStars(countOfStars));
            return newString.ToArray();
}

        static string LineOfStars(int countOfStars)
        {
            string newString = "";
            for (int i = 0; i < countOfStars + 2; i++)
            {
                newString += "*";
            }
            return newString;
        }