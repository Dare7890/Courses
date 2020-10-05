bool variableName(string name) {
            string pattern = @"^([A-Z]+|[a-z]+|_)((\w*)|(_*))$";
            if (Regex.IsMatch(name, pattern, RegexOptions.IgnoreCase))
                return true;
            else
                return false;
}
