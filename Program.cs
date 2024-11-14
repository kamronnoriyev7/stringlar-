// HOMEWORK 
// 1
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         string result;
//         Function(input, out result);
//         Console.WriteLine(result);
//     }
//
//     public static void Function(string input, out string result)
//     {
//         result = string.Empty;
//         for (int i = 0; i < input.Length; i++)
//         {
//             result += input[input.Length - 1 - i];
//         }
//     }
// }
using System;
using System.Collections.Generic;

// 2
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         int unliNumber ;
//         int undoshNumber ;
//         NumberFiltration(input,  out unliNumber, out undoshNumber);
//         Console.WriteLine($"Unli harflar soni: {unliNumber}\nUndosh harflar soni: {undoshNumber}");
//         
//     }
//
//     public static void NumberFiltration(string input, out int unliNumber, out int undoshNumber)
//     {
//         unliNumber = 0;
//         undoshNumber = 0;
//         var inputLower = input.ToLower();
//         foreach (var element in inputLower)
//         {
//             if (char.IsLetter(element))
//             {
//                 if (element=='a' || element=='u' || element=='i' || element=='o' || element=='e')
//                 {
//                     ++unliNumber;
//                 }
//                 else
//                 {
//                     ++undoshNumber;
//                 }
//             }
//         }
//     }
// }

// 3
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         bool result;
//         Function(input, out result);
//         Console.WriteLine(result);
//     }
//
//     public static void Function(string input, out bool result)
//     {
//         var inputEdit = string.Empty;
//         for (int i = 0; i < input.Length; i++)
//         {
//             inputEdit += input[input.Length - 1 - i];
//         }
//
//         if (input==inputEdit)
//         {
//             result = true;
//         }
//         else
//         {
//             result = false;
//         }
//     }
// }

// 4
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         int number;
//         TextEmpty(input, out number);
//         Console.WriteLine($"{ number } ta");
// }
//
//     public static void TextEmpty(string input, out int number)
//     {
//         number = 0;
//         for (var i = 0; i < input.Length; i++)
//         {
//             if (char.IsLetter(input[i]) &&  input[i+1]==' ')
//             {
//                 ++number;
//             }
//         }
//     }
// }


// 5

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         int count;
//         char letter;
//         RepeatedLetter(input, out count, out letter);
//         Console.WriteLine($"{letter}:  {count} ta \n");
//     }
//
//     public static void RepeatedLetter(string input, out int count, out char letter)
//     {
//         count = 0;
//         letter = ' ';
//         var maxcount = 0;
//         for (int i = 0; i < input.Length - 1; i++)
//         {
//             var countedit = 0;
//             if (char.IsLetter(input[i]))
//             {
//                 for (int j = 1; j < input.Length; j++)
//                 {
//                     if (input[i] == input[j])
//                     {
//                         ++countedit;
//                     }
//                 }
//
//                 if (countedit > maxcount)
//                 {
//                    maxcount = countedit;    
//                     letter = input[i];
//                 }
//             }
//         }
//         count=maxcount;
//     }
// }

// 6 
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         string output ;
//         EmptyRemove(input, out output);
//         Console.WriteLine(output);
//     }
//
//     public static void EmptyRemove(string input, out string output)
//     {
//         input = input.Trim();
//         output = "";
//         foreach (var element in input)
//         {
//             if (element!=' ')
//             {
//                 output += element;
//             }
//         }
//     }
// }

// 1
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr1: ");
//         var text1 = Console.ReadLine();
//         Console.Write("satr2: ");
//         var text2 = Console.ReadLine();
//         bool boolText;
//         Run(text1, text2, out boolText);
//         Console.WriteLine(boolText);
//     }
//
//     public static void Run(string text1, string text2, out bool boolText)
//     {
//         text1 = text1.Trim();
//         text2 = text2.Trim();
//         boolText = false;
//         var count = 0;
//         for (int i = 0; i < text1.Length; i++)
//         {
//             for (int j = 0; j < text2.Length; j++)
//             {
//                 if (text1[i]==text2[j])
//                 {
//                     ++count;
//                 }
//             }
//
//             if (count==text1.Length)
//             {
//                 boolText = true;
//             }
//             else
//             {
//                 boolText = false;
//             }
//         }
//     }
// }

// 2
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var text = Console.ReadLine();
//         string arrayText ;
//         ArrayLong(text, out arrayText);
//         Console.WriteLine($"natija: {arrayText}");
//     }
//
//     public static void ArrayLong(string text, out string arrayText)
//     {
//         arrayText = "";
//         var IntMax = int.MinValue;
//         var textToArray = text.Split(" ");
//         for (int i = 0; i <textToArray.Length; i++)
//         {
//             if (textToArray[i].Length > IntMax)
//             {
//                 IntMax = textToArray[i].Length; 
//                 arrayText = textToArray[i];
//             }
//         }
//         
//     }
// }

// 3
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("satr: ");
        var text = Console.ReadLine();
        char arrayText ;
        ArrayLong(text, out arrayText);
        Console.WriteLine($"natija: {arrayText}");
    }

    public static void ArrayLong(string text, out char arrayText)
    {
        char[] arrayNew = new char[text.Length];
        var SplitText = text.Split(" ");
        for (int i = 0; i <SplitText.Length ; i++)
        {
            for (int j = 0; j <SplitText.Length; j++)
            {
                
            }
        }
            
    }
}











































































































































































































