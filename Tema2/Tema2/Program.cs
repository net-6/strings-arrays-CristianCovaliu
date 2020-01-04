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
            //Strings17();
            //Strings18();
            //Strings19();
            //Strings20();
            //Strings21();
            //Strings22();
            //Strings23();
            //Strings24();
            //Strings25();
            //Strings26();
            //Strings27();

            //Arrays1();
            //Arrays2();
            //Arrays3();
            //Arrays4();
            //Arrays5();
            //Arrays6();
            //Arrays7();
            //Arrays8();
            //Arrays9();
            //Arrays10();
            //Arrays11();
            //Arrays12();
            //Arrays13();
            //Arrays14();
            //Arrays15();
            //Arrays16();
                     
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

        //Write a method to get a string made of the first 2 and the last 2 chars from a given string. 
        //If the string length is less than 2, return instead of the empty string.
        static void Strings17()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            if (input.Length > 1)
            {
               
                Console.WriteLine(input.Substring(0, 2) + input.Substring(input.Length-2));
            }
            else
            {
                input = string.Empty;
                Console.WriteLine(input);
            }
        }

        //Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
        static void Strings18()
        {
            Console.WriteLine("Please insert input string: ");
            string input = Console.ReadLine();

            char one = input[0];
            string two = input.Substring(1);

            Console.WriteLine(one + two.Replace(one, '$'));
        }

        //Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        static void Strings19()
        {
            Console.WriteLine("Please insert first string: ");
            string first = Console.ReadLine();

            Console.WriteLine("Please insert second string: ");
            string second = Console.ReadLine();

            string a = first.Substring(0, 2);
            string b = second.Substring(0, 2);

            string third = b + first.Substring(2) + " " + a + second.Substring(2);
            Console.WriteLine("The result is: {0}", third);
        }

        //Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. 
        //Return the resulting string.
        static void Strings20()
        {
            Console.WriteLine("Please insert input: ");
            string str1 = Console.ReadLine();
           
            int snot = str1.IndexOf("not"); 
            int spoor = str1.IndexOf("poor");

            if (spoor > snot & snot >0)
            {
                string remove = str1.Substring(snot, (spoor - snot) + 4);
                str1 = str1.Replace(remove, "good");
                Console.WriteLine(str1);
            }
            else
            {
                Console.WriteLine(str1);
            }
        }

        //Write a method that takes a list of words and returns the length of the longest one.
        static void Strings21()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();
            string [] separator = { " " };
            string[] result = input.Split(separator, StringSplitOptions.None);
            int wordLength = 0;
            for (int i = 0; i < result.Length; i++)
            {               
                if (result[i].Length > wordLength)
                {
                    wordLength = result[i].Length;
                }
            }
            Console.WriteLine("The longest word have {0} characters", wordLength);

            


        }

        //Write a method to get the last part of a string before a specified character.
        static void Strings22()
        {
            Console.WriteLine("Please insert input: ");
            string input = Console.ReadLine();

            Console.Write("Character to remove from: ");
            string removeFrom = Console.ReadLine();

            int a = input.IndexOf(removeFrom);

            Console.WriteLine(input.Remove(a));
        }

        //Write a method to check whether a string starts with specified characters
        static void Strings23()
        {
            Console.WriteLine("Please insert input:");
            string input = Console.ReadLine();

            Console.Write("Character to check: ");
            string check = Console.ReadLine();

            if (input[0] == check[0])
            {
                Console.WriteLine("Yes, starts with {0}", check);
            }
            else
            {
                Console.WriteLine("No, it does not start with {0}", check);
            }
        }

        //Write a method to count occurrences of a substring in a string
        static void Strings24()
        {
            Console.WriteLine("Please insert input:");
            string input = Console.ReadLine();

            Console.Write("Character to check: ");
            string check = Console.ReadLine();
            int count = 0;
            int i = 0;

            while ((i = input.IndexOf(check, i)) != -1)
            {
                i += check.Length;
                count++;
            }           
            Console.WriteLine(count);
        }

        //Write a method to swap comma and dot in a string.
        static void Strings25()
        {
            Console.WriteLine("Please insert input:");
            string input = Console.ReadLine();
            input = input.Replace(',', '|').Replace('.', ',').Replace('|', '.');
            
            Console.WriteLine(input);
        }

        //Write a method to remove spaces from a given string.
        static void Strings26()
        {
            Console.WriteLine("Please insert input:");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ' ')
                {
                    sb = sb.Remove(i, 1);
                }
            }
            Console.WriteLine(sb.ToString());
        }

        //Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True
        static void Strings27()
        {
            Console.WriteLine("Please insert input:");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            string revearsed = sb.ToString();
            if (input.Equals(revearsed))
            {
                Console.WriteLine("{0} is a palindrome", input);
            }
            else
            {
                Console.WriteLine("{0} is NOT a palindrome", input);
            }
        }


        //Arrays
        //Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.
        static void Arrays1()
        {
            int[] inputArray = {1,2,3,4,5};
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine("element[{0}] = {1}",i, inputArray[i]);
            }
        }

        //Write a method to reverse the order of the items in the array.
        static void Arrays2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

            int[] revearsed = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                revearsed[array.Length - i - 1] = array[i];
            }

            foreach (var element in revearsed)
            {
                Console.Write("{0} ", element);
            }
        }

        //Write a method to get the number of occurrences of a specified element in an array.
        static void Arrays3()
        {
            Console.WriteLine("Please insert input:");
            string input = Console.ReadLine();

            Console.WriteLine("Please insert element to search:");
            string element = Console.ReadLine();


            char[] inputArray = input.ToCharArray();
            char[] elementArray = element.ToCharArray();
            int occurrences = 0;

            foreach (char item in inputArray)
            {
                if (item == elementArray[0])
                {
                    occurrences++;
                }
            }
            Console.WriteLine("We have {0} occurences of {1}", occurrences, element);
        }

        //Write a method to insert a new item before the second element in an existing array.
        static void Arrays4()
        { 
            int[] array = new int[10];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int position = 2;
            Console.WriteLine("Enter new item: ");
            int item = int.Parse(Console.ReadLine());
            for (int i=5; i >= position; i--)
            {
                array[i] = array[i - 1];
            }
            array[position - 1] = item;

            Console.WriteLine("Elements after insertion: ");
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //Write a method to remove a specified item using the index from an array.
        static void Arrays5()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element {0} with index -> {1}", array[i], i);
            }
                       
            Console.WriteLine("What index do you want to delete?");
            int index = int.Parse(Console.ReadLine());

            Array.Clear(array, index, 1);

            foreach (var element in array)
            {
                    Console.WriteLine(element);
            }
        }

        //Write a program to find the sum of all elements of the array
        static void Arrays6()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.Write("Array elements are: ");
            foreach (var item in array)
            {
                Console.Write("{0}", item);
            }
            int sum = array.Sum();
            Console.WriteLine();
            Console.WriteLine("Array sum is {0}", sum);
        }

        //Write a program to print all unique elements in an array.
        static void Arrays7()
        {
            int[] array = {1, 2, 2, 4, 4, 5};

            Console.WriteLine("Array elements are:");
            int[] uniqueArray = array.Distinct().ToArray();
            foreach (var item in array)
            {
                Console.WriteLine("{0}", item);
            }
            foreach (var distinct in uniqueArray)
            {
                Console.WriteLine("This element is unique: " + distinct);
            }
        }

        //Write a program to merge two arrays of same size sorted in ascending order.
        static void Arrays8()
        {
            int[] firstArray = {1, 8, 3, 7, 5};
            Console.WriteLine("My first array is:");
            foreach (var item in firstArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            int[] secondArray = {6, 2, 8, 4, 10};
            Console.WriteLine("My second array is:");
            foreach (var item in secondArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            int[] mergedArray = firstArray.Concat(secondArray).OrderBy(x => x).ToArray();
            Console.WriteLine("My merged array is:");
            foreach (var item in mergedArray)
            {
                Console.Write("{0} ", item);
            }
        }

        //Write a program to find maximum and minimum element in an array.
        static void Arrays9()
        {
            int[] array = { 1, 2, 2, 4, 4, 5 };
            Console.WriteLine("Array elements are:");
            foreach (var item in array)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("Maximum is: {0}", array.Max());
            Console.WriteLine("Minimum is: {0}", array.Min());
        }

        //Write a programin to separate odd and even integers in separate arrays
        static void Arrays10()
        {
            int[] array = { 1, 2, 2, 4, 4, 5 };
            Console.WriteLine("Array elements are:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            int[] oddArray = new int[array.Length];
            int[] evenArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 >= 1)
                {
                    oddArray[i]= array[i];
                    
                }
                if (array[i] % 2 == 0)
                {
                    evenArray[i] = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Odd array is: ");
            foreach (var item in oddArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("Even array is:");
            foreach (var item in evenArray)
            {
                Console.Write(item);
            }
        }

        //Write a program to sort elements of array in ascending order.
        static void Arrays11()
        {
            int[] array = { 1, 8, 3, 7, 5 };
            Console.WriteLine("My array is:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int[] orderArray = array.OrderBy(x => x).ToArray();
            Console.WriteLine("My ordered array is:");
            foreach (var item in orderArray)
            {
                Console.Write("{0} ", item);
            }  
        }

        //Write a program to sort elements of the array in descending order.
        static void Arrays12()
        {
            int[] array = { 1, 8, 3, 7, 5 };
            Console.WriteLine("My array is:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int[] orderArray = array.OrderByDescending(x => x).ToArray();
            Console.WriteLine("My ordered array is:");
            foreach (var item in orderArray)
            {
                Console.Write("{0} ", item);
            }
        }

        //Write a program to find the second largest element in an array.
        static void Arrays13()
        {
            int[] array = { 1, 8, 3, 7, 5 };
            Console.WriteLine("My array is:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int[] orderArray = array.OrderBy(x => x).ToArray();
            Console.WriteLine("My second largest element is: {0}", orderArray[^2]);
        }

        //Write a program to find the second smallest element in an array.
        static void Arrays14()
        {
            int[] array = { 1, 8, 3, 7, 5 };
            Console.WriteLine("My array is:");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int[] orderArray = array.OrderBy(x => x).ToArray();
            Console.WriteLine("My second largest element is: {0}", orderArray[1]);
        }

        //Write a program for a 2D array of size 3x3 and print the matrix.
        static void Arrays15()
        {
            int[,] array =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0} ", array[row, col]);
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp for addition of two Matrices of same size
        static void Arrays16()
        {
            int[,] firstArray =
            {
                {1, 2, 3},
                {4, 5, 6}
            };
            Console.WriteLine("First array is: ");
            for (int row = 0; row < firstArray.GetLength(0); row++)
            {
                for (int col = 0; col < firstArray.GetLength(1); col++)
                {
                    Console.Write("{0} ", firstArray[row, col]);
                }
                Console.WriteLine();
            }

            int[,] secondArray =
            {
                {1, 2, 3},
                {4, 5, 6}
            };
            Console.WriteLine("Second array is: ");
            for (int row = 0; row < secondArray.GetLength(0); row++)
            {
                for (int col = 0; col < secondArray.GetLength(1); col++)
                {
                    Console.Write("{0} ", secondArray[row, col]);
                }
                Console.WriteLine();
            }

            var firstArraySum = 0;
            var secondArraySum = 0;

            for (int rows = 0; rows < firstArray.GetLength(0); rows++)
            {
                
                for (int cols = 0; cols < firstArray.GetLength(1); cols++)
                {
                    firstArraySum += firstArray[rows, cols];
                }
            }

            for (int rows = 0; rows < secondArray.GetLength(0); rows++)
            {

                for (int cols = 0; cols < secondArray.GetLength(1); cols++)
                {
                    secondArraySum += secondArray[rows, cols];
                }
            }

            Console.WriteLine("The sum of the two arrays is: " + (firstArraySum + secondArraySum));
        }
    }
}
