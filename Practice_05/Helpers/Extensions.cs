using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice_05.Helpers
{
    public static class Extensions
    {
        public static bool IsNumeric(this string val)
        {
            var pattern = @"^[0-9]+$";

            if (Regex.IsMatch(val, pattern))
            {
                return true;
            }

            return false;
        }
    }
}
