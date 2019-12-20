using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings1();
            //Strings2();
            //Strings3();
            //Strings4();
            //Strings5();
            //Strings6();
            //Strings7();
            //Strings8();
            //Strings9();
            //Strings10();
            //Strings11();
            //Strings12();
            //Strings13();
            //Strings14();
            //Strings15();
            //Strings16();
        }

        ///Strings & Arrays homework
        ///Strings
        ///Write a method that to remove the nth index character from a nonempty string.
        static void Strings1()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            int length = input.Length;

            Console.WriteLine("Please insert character number to remove from 0 to " + length);
            int character = int.Parse(Console.ReadLine());

            string removed = input.Remove(character, 1);
            Console.Write("The output is: " + removed);
        }

        // Write a method that to remove the characters which have odd index values of a given string.
        static void Strings2()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            //The following version use a StringBuilder object 

            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sb.Append(input[i]);
            //    } 
            //}
            //Console.WriteLine(sb.ToString());

            //Version 2
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(input[i]);
                }
            }

        }

        // Write a method that takes input from the user and displays that input back in upper and lower cases.
        static void Strings3()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            string lowerCase = input.ToLower();
            string upperCase = input.ToUpper();

            Console.WriteLine(lowerCase);
            Console.WriteLine(upperCase);

        }

        //Write a method that reverses a string if it's length is a multiple of 4
        static void Strings4()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            if (input.Length % 4 == 0)
            {              
                StringBuilder sb = new StringBuilder();
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    sb.Append(input[i]);
                }
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine(input);
            }
        }

        //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
        static void Strings5()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            string fourChar = input.Substring(0, 4);

            int upchar = 0;
            for (int i = 0; i < fourChar.Length; i++)
            {
                char ch = fourChar[i];
                if (ch >='A' && ch <= 'Z' )
                {
                    upchar++;
                }
            }
            if (upchar >= 2)
            {
                Console.WriteLine(input.ToUpper());
            }
            else
            {
                Console.WriteLine(input);
            }
        }

        //Write a method that to remove a newline.
        static void Strings6()
        {
            string input = "Hello!!\nHow are you today?\nGlad to hear that.";
            Console.WriteLine(input);
            Console.WriteLine();
            StringBuilder sb = new StringBuilder(input);
            sb.Replace('\n', ' ');
            Console.WriteLine(sb.ToString());
        }

        //Write a method to display formatted text (width=50) as output. 
        //For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. 
        //In this case we will have 3 lines of text.
        static void Strings7()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 50 == 0 )
                {
                    sb.Insert(i, "\n");
                }
               
            }
            Console.WriteLine(sb.ToString());

    }

        //Write a method that formats a number with a percentage.
        static void Strings8()
        {
            Console.WriteLine("Please insert input number: ");
            double input = double.Parse(Console.ReadLine());
           
            string s = input.ToString("P2", CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(s);

        }

        //Write a method that reverses a string
        static void Strings9()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();
           
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        //Write a method that strips a set of characters from a string.
        static void Strings10()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Please mention characters to remove: ");
            string removeChar = Console.ReadLine();

            char[] charArray = removeChar.ToCharArray();
            string returnText = input;
            foreach (char item in charArray)
            {
                while (returnText.IndexOf(item) > -1)
                {
                    returnText = returnText.Remove(returnText.IndexOf(item), 1);
                }
            }
            Console.WriteLine(returnText);
        }

        //Write a method that transforms to lowercase first n characters in a string
        static void Strings11()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Please write number of characters:");
            int n = int.Parse(Console.ReadLine());

            string lowerCase = input.Substring(0, n);
            lowerCase = lowerCase.ToLower();
            Console.WriteLine(lowerCase + input.Substring(n));
            

        }

        //Write a method to capitalize first and last letters of each word of a given string.
        static void Strings12()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            char[] ch = input.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                int a = i;
                while (i < ch.Length && ch[i] != ' ')
                {
                    i++;
                }
                if ((ch[a] >= 'a' && ch[a] <= 'z'))
                {
                    ch[a] = char.ToUpper(ch[a]);
                }
                if ((ch[i-1] >= 'a' && ch[i-1] <= 'z'))
                {
                    ch[i - 1] = char.ToUpper(ch[i - 1]);
                }               
            }
            Console.WriteLine(ch);
        }

        //Write a method to compute sum of digits of a given string(if any).
        static void Strings13()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            char[] ch = input.ToCharArray();
            var sum = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    double a = char.GetNumericValue(ch[i]);
                    sum += (int)a;
                }
            }
            Console.WriteLine("Sum of digits is {0}", sum);
        }

        //Clean the text
        //You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there( ^ <, > &+ @%$)
        static void Strings14()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();
            string removeChars = "^<,>&+@%$";

            foreach (char ch in removeChars)
            {
                input= input.Replace(ch, ' ');
            }

            Console.WriteLine(input);
        }

        //Write a method to add 'ing' at the end of a given string (length should be at least 3). 
        //If the given string already ends with 'ing' then add 'ly' instead. 
        //If the string length of the given string is less than 3, leave it unchanged.
        static void Strings15()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            string a = "ing";
            string b = "ly";

            if (input.Length >= 3)
            {
                if (input.EndsWith(a))
                {
                    string inputLy = input.Insert(input.Length, b);
                    Console.WriteLine("The modified string: '{0}'", inputLy);
                }
                else
                {
                    string inputIng = input.Insert(input.Length, a);
                    Console.WriteLine("The modified string: '{0}'", inputIng);
                }
            }
            else
            {
                Console.WriteLine(input);
            }
            

        }

        //You have some text that contains your email address. And you want to hide that. 
        //You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. 
        //Assume your email address will always be in format [username]@[domain]. 
        //You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. 
        //You will get as input the email address you need to obfuscate
        static void Strings16()
        {
            Console.WriteLine("Please insert email address: ");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            int a = input.IndexOf('@');
            for (int i = 0; i < a; i++)
            {
                sb[i]= '*';
            }         
            Console.WriteLine(sb.ToString());
        }
    }
}
