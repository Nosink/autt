using System.Text.RegularExpressions;

public static class Validator {

    public static bool IsValidEmail(string email) {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        // Check with Regex
        string lPatter = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+$";
        return Regex.IsMatch(email, lPatter);
    }

    public static bool IsValidPassword(string password) {
        return !string.IsNullOrWhiteSpace(password);
    }

}