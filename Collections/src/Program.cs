namespace CollectionsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

                string? nullValue = null;

                Console.WriteLine("=== Egyptian Phone Tests ===");

            Console.WriteLine($"01012345678 => {"01012345678".IsValidEgyptianPhone()} | Expected: True");
            Console.WriteLine($"+201512345678 => {"+201512345678".IsValidEgyptianPhone()} | Expected: True");
            Console.WriteLine($"01312345678 => {"01312345678".IsValidEgyptianPhone()} | Expected: False");
            Console.WriteLine($"0101234567 => {"0101234567".IsValidEgyptianPhone()} | Expected: False");
            Console.WriteLine($"0101234567a => {"0101234567a".IsValidEgyptianPhone()} | Expected: False");
            Console.WriteLine($"null => {nullValue.IsValidEgyptianPhone()} | Expected: False");
            Console.WriteLine($"empty => {"".IsValidEgyptianPhone()} | Expected: False");
            Console.WriteLine($"spaces => {"   ".IsValidEgyptianPhone()} | Expected: False");

            Console.WriteLine();
            Console.WriteLine("=== Egyptian National ID Tests ===");

            Console.WriteLine($"29901011234567 => {"29901011234567".IsValidEgyptianNationalId()} | Expected: True");
            Console.WriteLine($"19901011234567 => {"19901011234567".IsValidEgyptianNationalId()} | Expected: False");
            Console.WriteLine($"2990101123456 => {"2990101123456".IsValidEgyptianNationalId()} | Expected: False");
            Console.WriteLine($"null => {nullValue.IsValidEgyptianNationalId()} | Expected: False");
            Console.WriteLine($"empty => {"".IsValidEgyptianNationalId()} | Expected: False");
            Console.WriteLine($"spaces => {"   ".IsValidEgyptianNationalId()} | Expected: False");

        }
    }
}
