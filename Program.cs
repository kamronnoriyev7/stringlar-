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

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("satr: ");
        var input = Console.ReadLine();
         Console.Write("satr: ");
        var input = Console.ReadLine();
        
    }

    public static void Run()
    {
        
    }
}












































































































































































































