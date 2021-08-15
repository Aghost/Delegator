using System;
using System.Text.RegularExpressions;

namespace Delegator.Lib
{
    public static class PredicateLib {
        public static Predicate<string> isValidEmail = email => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}
