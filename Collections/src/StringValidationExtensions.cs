using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CollectionsLab
{


    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string? phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            const string pattern = @"^(?:01[0125]\d{8}|\+201[0125]\d{8})$";

            return Regex.IsMatch(phone, pattern);
        }

        public static bool IsValidEgyptianNationalId(this string? nationalId)
        {
            if (string.IsNullOrWhiteSpace(nationalId))
                return false;

            const string pattern = @"^[23]\d{13}$";

            return Regex.IsMatch(nationalId, pattern);
        }
    }

}
