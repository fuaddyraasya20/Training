using System;

namespace Warm_Up
{
    // Validasi jika input adalah huruf, maka warning
    public class NumberValidation
    {
        public string WarningMessage { get; set; }
        public bool IsValidNumber(string input, out int menu)
        {
            // Check if input is a number
            if (int.TryParse(input, out menu))
            {
                WarningMessage = null;
                return true;
            }
            else
            {
                WarningMessage = "Invalid Input. Please input number.";
                return false;
            }
        }
    }
    public class YesNoValidation
    {
        public string WarningMessage { get; set; }
        public bool IsValidYesNo(string input)
        {
            if (input.ToUpper() == "Y" || input.ToUpper() == "T")
            {
                WarningMessage = null;
                return true;
            }
            else
            {
                WarningMessage = "Invalid Input. Please Input Y or T";
                return false;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args) { }
        public Program()
        {
            bool loop = true;

            NumberValidation numberValidation = new NumberValidation();
            int menu;

            YesNoValidation yesNoValidation = new YesNoValidation();

            while (loop)
            {
                Console.WriteLine("01. Warm Up");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("01. Solve Me First");
                Console.WriteLine("-------------------------------------");
                Console.Write("Select Number : ");
                string inputNumber = Console.ReadLine();
                // Validasi jika input adalah selain angka maka warning invalid input (menggunakan oop)
                if (numberValidation.IsValidNumber(inputNumber, out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            Console.Clear();
                            SolveMeFirst solveMeFirst = new SolveMeFirst();
                            break;
                        default:
                            Console.WriteLine(numberValidation.WarningMessage);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(numberValidation.WarningMessage);
                }

                do
                {
                    if (!string.IsNullOrEmpty(yesNoValidation.WarningMessage))
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine(yesNoValidation.WarningMessage);
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                    }
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Apakah anda akan lanjut 00. Warm Up ? (Y/T) : ");
                    string inputYesNo = Console.ReadLine().ToUpper();

                    // Membersihkan pesan kesalahan sebelumnya
                    yesNoValidation.WarningMessage = null;

                    if (yesNoValidation.IsValidYesNo(inputYesNo))
                    {
                        if (inputYesNo == "Y")
                        {
                            Console.Clear();
                            loop = true;
                            break;
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                } while (loop);
            }
        }
    }
}
