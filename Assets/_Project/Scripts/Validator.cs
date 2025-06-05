using System.Text.RegularExpressions;

public static class Validator {

    public static bool IsValidEmail(string email) {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        // Check with Regex
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+$";
        return Regex.IsMatch(email, pattern);
    }

    public static bool IsPasswordEmpty(string password) {
        return string.IsNullOrWhiteSpace(password);
    }
}
