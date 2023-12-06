using System;

class Program
{
    static void Main()
    {

        Console.Write("Nhập một số nguyên không âm (tối đa 2 chữ số): ");
        int so = int.Parse(Console.ReadLine());


        if (so >= 0 && so < 10)
        {
            switch (so)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }
        }

        else if (so >= 10 && so < 20)
        {
            int ones = so % 10;
            switch (ones)
            {
                case 0:
                    Console.WriteLine("Ten");
                    break;
                case 1:
                    Console.WriteLine("Eleven");
                    break;
                case 2:
                    Console.WriteLine("Twelve");
                    break;
                case 3:
                    Console.WriteLine("Thirteen");
                    break;
                case 4:
                    Console.WriteLine("Fourteen");
                    break;
                case 5:
                    Console.WriteLine("Fifteen");
                    break;
                case 6:
                    Console.WriteLine("Sixteen");
                    break;
                case 7:
                    Console.WriteLine("Seventeen");
                    break;
                case 8:
                    Console.WriteLine("Eighteen");
                    break;
                case 9:
                    Console.WriteLine("Nineteen");
                    break;
            }
        }

        else if (so >= 20 && so < 100)
        {
            int hagnchuc = so / 10;
            int ones = so % 10;

            Console.Write($"{dochangchuc(hagnchuc)}");
            if (ones > 0)
            {
                Console.Write($" {dochangdonvi(ones)}");
            }

            Console.WriteLine();
        }
        else if (so >= 100 && so < 1000)
        {
            int hundreds = so / 100;
            int remainingTwoDigits = so % 100;

            Console.Write($"{dochangdonvi(hundreds)} hundred");

            if (remainingTwoDigits > 0)
            {
                Console.Write($" and {docso(remainingTwoDigits)}");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Số không hợp lệ. Vui lòng nhập số từ 0 đến 999.");
        }
    }


    static string dochangchuc(int hangchuc)
    {
        string[] hangchuctu = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        return hangchuctu[hangchuc];
    }

    static string dochangdonvi(int ones)
    {
        string[] onesWords = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return onesWords[ones];
    }

    static string docso(int so)
    {
        if (so < 10)
        {
            return dochangdonvi(so);
        }
        else if (so < 20)
        {
            return ReadTeens(so % 10);
        }
        else
        {
            int hangchuc = so / 10;
            int ones = so % 10;
            return $"{dochangchuc(hangchuc)} {dochangdonvi(ones)}";
        }
    }

    static string ReadTeens(int teens)
    {
        string[] teensWords = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        return teensWords[teens];
    }
}

