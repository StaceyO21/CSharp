using System;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {

        public static void UsingEscapeCharacters()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);
            string invalidFilePath = "C:\data\employeelist.xlsx";//invalid because of the one slash
            string filePath = "C:\\data\\employeelist.xlsx";// or use verbatim string @"C:\data\employeelist.xlsx"
            

            string marketingTagLine = "Baking the \"best pies\" ever";

        }

        pubic static void ManipulatingStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullName = firstName + " " + lastName; //concatination
            string employeeIdentification = string.Concat(firstName, lastName); //method to concatinate

            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower(); //trim is method to get rid of leading or trailing spaces

            int length = empId.Length; //length is a property 

            if(fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }

            string subString = fullName.Substring(1, 3);
            console.WriteLine("Characters 2 to 4 of fullName are " + subString);

            string userNameWithInterpolation = $"{firstName}-{lastName}";//another way to concatinate
        }
        public static void UsingSimpleStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var = userName = "BethanyS";
            userName = userName.ToLower();

            userName = ""; //identical to string.Empty;
        }

        public static void UsingExpressionBodiedSyntax()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmpolyee1 = CalculateYearlyWageExpressionBodied(amount, months,
                bonus);

            Console.WriteLine($"Yearly wage for employee 1 (Bethany):" +
                $"{yearlyWageForEmpolyee1}");
        }

        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int
            numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;
    }
}
