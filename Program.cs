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

// HOMEWORK 1.5
// 1
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("n: ");
//         var countElement = int.Parse(Console.ReadLine());
//         var array = new int[countElement];
//         int Count ;
//         Class3Search(array,out  Count);
//         Console.WriteLine(Count);
//     }
//
//     public static void Class3Search(int[] array , out int Count)
//     {
//         Count = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (99<number && number<1000)
//             {
//                 ++Count;
//             }
//             array[i] = number;
//         }
//     }
// }

// 2
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("n: ");
//         var countElement = int.Parse(Console.ReadLine());
//         var array = new int[countElement];
//         int evenNumberCount ;
//         Class3Search(array,out  evenNumberCount);
//         Console.WriteLine(evenNumberCount);
//     }
//
//     public static void Class3Search(int[] array , out int evenNumberCount)
//     {
//         evenNumberCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (number % 2 == 0)
//             {
//                 ++evenNumberCount;
//             }
//             array[i] = number;
//         }
//     }
// }

// 3
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("n: ");
//         var countElement = int.Parse(Console.ReadLine());
//         var array = new int[countElement];
//         int oddNumberCount ;
//         Class3Search(array,out  oddNumberCount);
//         Console.WriteLine(oddNumberCount);
//     }
//
//     public static void Class3Search(int[] array , out int oddNumberCount)
//     {
//         oddNumberCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (number % 2 != 0)
//             {
//                 ++oddNumberCount;
//             }
//             array[i] = number;
//         }
//     }
// }


// 4
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("n: ");
//         var countElement = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         int NumberCount ;
//         Class3Search(list,out  NumberCount, countElement);
//         Console.WriteLine(NumberCount);
//     }
//
//     public static void Class3Search(List<int> list, out int NumberCount, int countElement )
//     {
//         NumberCount = 0;
//         for (int i = 0; i <countElement ; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             list.Add(number);
//             if (number%3==0 && number%7==0)
//             {
//                 ++NumberCount;
//             }
//             
//         }
//     }
// }


// 6

using System.Net.Sockets;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("n: ");
//         var count = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         Replacement(out list, count);
//         foreach (var element in list)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void Replacement(out List<int> list, int count)
//     {
//         int digitFirst = 0;
//         int digitLast = 0;
//         list = new List<int>();
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             list.Add(number);
//         }
//         (list[0], list[count - 1]) = (list[count - 1], list[0]);
//     }
// }

// 7
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("n: ");
//         var countElement = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         var boolAlpha = Bool(list, countElement);
//         Console.WriteLine(boolAlpha);
//     }
//
//     public static bool Bool(List<int> list, int countElement)
//     {
//         var countEven = 0;
//         var countOdd = 0;
//         for (int i = 0; i < countElement; i++)
//         {
//             Console.Write($"{i}: ");
//             var value = int.Parse(Console.ReadLine());
//             list.Add(value);
//             if (value % 2 == 0)
//             {
//                 countEven++;
//             }
//             else
//             {
//                 countOdd++;
//             }
//         }
//
//         if (countEven < countOdd)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }

// 14
// 
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("n: ");
//         var count=int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         int minElement;
//         MinElementSearch(list, out minElement, count);
//         Console.WriteLine("Min Element: " + minElement);
//
//     }
//
//     public static void MinElementSearch(List<int> list,out int minElement, int count)
//     {
//         minElement = int.MaxValue;
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (number<minElement)
//             {
//                 minElement=number;
//             }
//             list.Add(number);
//         }
//     }
// }

// 15
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("n: ");
//         var count=int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         int minElement;
//         int maxElement;
//         MinElementSearch(list, out minElement, out maxElement, count);
//         Console.WriteLine(maxElement + minElement);
//
//     }
//
//     public static void MinElementSearch(List<int> list,out int minElement,out int maxElement, int count)
//     {
//         minElement = int.MaxValue;
//         maxElement = int.MinValue;
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (number<minElement)
//             {
//                 minElement=number;
//             }
//
//             if (number > maxElement)
//             {
//                 maxElement = number;
//             }
//             list.Add(number);
//         }
//     }
// }

// 21
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var count = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         bool boolList;
//         IncreasingOrDecreasing(list, out boolList, count);
//         if (boolList,)
//         {
//         }
//
//         Console.WriteLine(boolList);
//     }
//
//     public static void IncreasingOrDecreasing(List<int> list, out bool boolList, int count)
//     {
//         boolList = false;
//         int minvalue = int.MaxValue;
//         int maxvalue = int.MinValue;
//         int countMin = 0;
//         int countMax = 0;
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = Convert.ToInt32(Console.ReadLine());
//             list.Add(number);
//             if (number < minvalue)
//             {
//                 minvalue = number;
//                 ++countMin;
//             }
//
//             if (number > maxvalue)
//             {
//                 maxvalue = number;
//                 ++countMax;
//             }
//         }
//
//         if (countMax == count)
//         {
//             boolList = true;
//         }
//
//         else if (countMin == count)
//         {
//             boolList = false;
//         }
//         else
//         {
//             Console.WriteLine("Error");
//         }
//     }
// }

// 23
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var count = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         MaxReplaceMin(out list, count);
//         foreach (var element in list)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void MaxReplaceMin(out List<int> list, int count)
//     {
//         list = new List<int>();
//         var maxValue = int.MinValue;
//         int locationMax = 0;
//         var minValue = int.MaxValue;
//         int locationMin = 0;
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = Convert.ToInt32(Console.ReadLine());
//             list.Add(number);
//             if (number > maxValue)
//             {
//                 maxValue = number;
//                 locationMax = i;
//             }
//
//             if (number < minValue)
//             {
//                 minValue = number;
//                 locationMin = i;
//             }
//         }
//         list[locationMax] = minValue;
//         list[locationMin] = maxValue;
//     }
// }

// 25
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var count = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         int index;
//         MaxAdjecentToDisplay(list, out index, count);
//         Console.WriteLine(list[index]);
//         Console.WriteLine(list[index + 1]);
//         
//     }
//
//     public static void MaxAdjecentToDisplay(List<int> list, out int index, int count)
//     {
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = Convert.ToInt32(Console.ReadLine());
//             list.Add(number);
//         }
//
//         index = 0;
//         var maxValue = int.MinValue;
//         for (int i = 0; i < count-1; i++)
//         {
//             if (list[i] + list[i + 1] > maxValue)
//             {
//                 maxValue = list[i] + list[i + 1];
//                 index = i;
//             }
//         }
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("satr: ");
//         var count= int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         int maxLeftCount;
//         MaxLeftAdjecent(list, count, out maxLeftCount);
//         Console.WriteLine(maxLeftCount);
//     }
//     
//     public static void MaxLeftAdjecent(List<int> list, int count,out int maxLeftCount)
//     {
//         maxLeftCount = 0;
//         int maxLeft = 0;
//         for (var i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             list.Add(number);
//             if (i==0)
//             {
//                  maxLeft = number;
//             }
//             if (number > maxLeft)
//             {
//                 maxLeft = number;
//                 ++maxLeftCount;
//             }
//         }
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter count list: ");
//         var count = Convert.ToInt32(Console.ReadLine());
//         var list1 = new List<int>();
//         var list2 = new List<int>();
//         var list3 = new List<int>();
//         NewList(list1, list2,out list3, count);
//         foreach (var element in list3)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void NewList(List<int> list1, List<int> list2, out List<int> list3, int count)
//     {
//         list1 = new List<int>();
//         list2 = new List<int>();
//         list3 = new List<int>();
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number1 = Convert.ToInt32(Console.ReadLine());
//             list1.Add(number1);
//         }
//
//         Console.WriteLine();
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var number2 = Convert.ToInt32(Console.ReadLine());
//             list2.Add(number2);
//         }
//
//         for (int i = 0; i <count; i++)
//         {
//             list3.Add(list1[i] * list2[i]);
//         }
//     }
// }

// 28
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("array length: ");
//         var count = Convert.ToInt32(Console.ReadLine());
//         var list = new List<string>();
//         int countchar;
//         SearchChar(list, out countchar, count);
//         Console.WriteLine(countchar);
//     }
//
//     public static void SearchChar(List<string> list, out int countchar, int count)
//     {
//         countchar = 0;
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var text = Console.ReadLine();
//             list.Add(text);
//         }
//
//         for (int i = 0; i < count; i++)
//         {
//             if (list[i][0]=='$')
//             {
//                 ++countchar;
//             }
//         }
//     }
// }

// 29
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("array length: ");
//         var count = Convert.ToInt32(Console.ReadLine());
//         var list = new List<string>();
//         SearchChar(list, count);
//     }
//
//     public static void SearchChar(List<string> list,  int count)
//     {
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var text = Console.ReadLine();
//             list.Add(text);
//         }
//
//         for (int i = 0; i < count; i++)
//         {
//             var countUpper = 0;
//             for (int j = 0; j < list[i].Length; j++)
//             {
//                 if (char.IsUpper(list[i][j]))
//                 {
//                     ++countUpper;
//                 }
//             }
//
//             if (countUpper == list[i].Length)
//             {
//                 Console.WriteLine(list[i]);
//             }
//         }
//     }
// }

// 30
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Count list: ");
//         var countList = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         FirstEqualAgain(list, countList);
//         foreach (var i in list)
//         {
//             Console.WriteLine(i);
//         }
//     }
//
//     public static void FirstEqualAgain(List<int> list, int countList)
//     {
//         var firstNumber = 0;
//         var counter = 0;
//         for (int i = 0; i < countList; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (number%2==0 && counter==0)
//             {
//                 firstNumber=number;
//                 ++counter;
//             }
//
//             if (number%2==0)
//             {
//                 number += firstNumber;
//             }
//             list.Add(number);
//         }
//
//     }
// }


// 31
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Count list: ");
//         var countList = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         FirstEqualAgain(list, countList);
//         foreach (var i in list)
//         {
//             Console.WriteLine(i);
//         }
//     }
//
//     public static void FirstEqualAgain(List<int> list, int countList)
//     {
//         var firstNumber = 0;
//         for (int i = 0; i < countList; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (number % 2 != 0)
//             {
//                 firstNumber = number;
//             }
//
//             list.Add(number);
//         }
//
//         for (int i = 0; i < countList; i++)
//         {
//             if (list[i]%2!=0)
//             {
//                 list[i]+= firstNumber;
//             }
//         }
//     }
// }

// 32
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Count list: ");
//         var countList = int.Parse(Console.ReadLine());
//         var list = new List<int>();
//         FirstEqualAgain(list, countList);
//         
//     }
//
//     public static void FirstEqualAgain(List<int> list, int countList)
//     {
//         var min= int.MaxValue;
//         for (int i = 0; i < countList; i++)
//         {
//             Console.Write($"{i}: ");
//             var number = int.Parse(Console.ReadLine());
//             if (i%2==0 && number<min )
//             {
//                 min = number;
//             }
//             list.Add(number);
//         }
//
//         Console.WriteLine(min);
//
//     }
// }

// 33
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Array elements count: ");
//         var count = int.Parse(Console.ReadLine());
//         var array1 = new int[count];
//         var array2 = new int[count];
//         int[] array3;
//         NewArray(array1, array2, out array3, count);
//         foreach (var element in array3)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void NewArray(int[] array1, int[] array2, out int[] array3, int count)
//     {
//         Console.WriteLine("Birinchi massiv elementlari: ");
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var digit1 = int.Parse(Console.ReadLine());
//             array1[i] = digit1;
//         }
//
//         Console.WriteLine();
//         Console.WriteLine("Ikkinchi massiv elementlari: ");
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var digit2 = int.Parse(Console.ReadLine());
//             array2[i] = digit2;
//         }
//
//         Console.WriteLine();
//         Console.WriteLine("Uchinchi massiv elementlari: ");
//         array3 = new int[count];
//         for (int i = 0; i < count; i++)
//         {
//             array3[i] = Math.Max(array1[i], array2[i]);
//         }
//     }
// }

// 34
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Array elements count: ");
//         var count = int.Parse(Console.ReadLine());
//         var array1 = new int[count];
//         int[] array2;
//         NewArray(array1, out array2, count);
//         Console.WriteLine($"Array elements count: {array2.Length} ta ");
//         foreach (var element in array2)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void NewArray(int[] array1, out int[] array2, int count)
//     {
//         var countArray = 0;
//         Console.WriteLine("Birinchi massiv elementlari: ");
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write($"{i}: ");
//             var digit1 = int.Parse(Console.ReadLine());
//             if (digit1 % 2 == 0)
//             {
//                 ++countArray;
//             }
//
//             array1[i] = digit1;
//         }
//         array2 = new int[countArray];
//         for (int i = 0, j = 0; i < count || j < countArray ; i++)
//         {
//             if (array1[i] % 2 == 0)
//             {
//                 array2[j] = array1[i];
//                 ++j;
//             }
//         }
//     }
// }













