using marCh3;
using System.Net;

//1
//Challenge 1 - Medium - 2022 - 11 - 27
Console.WriteLine("Challenge 1 - Medium");

Console.WriteLine(M_CounterpartCharCode.CounterpartCharCode('A')); //97
Console.WriteLine(M_CounterpartCharCode.CounterpartCharCode('a')); //65



//foreach (int i in abc)
//{
//    Console.Write(i + " ");
//}

//2
//Challenge 2 - Hard - 2022-11-27
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 2 - Hard");

Console.WriteLine(H_CanFind.CanFind(new string[] { "at", "be", "th", "au" }, new string[] { "beautiful", "the", "hat" })); //true
Console.WriteLine(H_CanFind.CanFind(new string[] { "ay", "be", "ta", "cu" }, new string[] { "maybe", "beta", "abet", "course" })); //false
Console.WriteLine(H_CanFind.CanFind(new string[] { "th", "fo", "ma", "or" }, new string[] { "the", "many", "for", "forest" })); //true
Console.WriteLine(H_CanFind.CanFind(new string[] { "oo", "mi", "ki", "la" }, new string[] { "milk", "chocolate", "cooks" })); //false



//3
//Challenge 3 - Very Hard - 2022-11-27
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 3 - Very Hard");

Console.WriteLine(VH_Simplify.Simplify("4/6")); // "2/3"
Console.WriteLine(VH_Simplify.Simplify("10/11")); // "10/11"
Console.WriteLine(VH_Simplify.Simplify("100/400")); // "1/4"
Console.WriteLine(VH_Simplify.Simplify("8/4")); // "2"
Console.WriteLine(VH_Simplify.Simplify("5/7")); // "5/7"
Console.WriteLine(VH_Simplify.Simplify("7/4")); // "7/4"
Console.WriteLine(VH_Simplify.Simplify("300/200")); // "3/2"
Console.WriteLine(VH_Simplify.Simplify("50/25")); // "2"
Console.WriteLine(VH_Simplify.Simplify("5/45")); // "1/9"


////4
////Challenge 4 - Easy - 2022-11-27
////Console.WriteLine("\n\n");
////Console.WriteLine("Challenge 4 - Expert");

Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 4, 5 })); // True
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 3, 2 })); // False
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 4, 2 })); // True
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 0, -4 })); // False
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { 1, 7 }, new int[] { 2, 4 }, new int[] { 9, 3 }, new int[] { 2, 6 })); // True
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { 1, 7 }, new int[] { 2, 4 }, new int[] { 9, 3 }, new int[] { 6, 5 })); // False
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { -2, 6 }, new int[] { 12, -3 }, new int[] { 1, 7 }, new int[] { 9, -1 })); // True
Console.WriteLine(Ex_WithinTriangle.WithinTriangle(new int[] { -2, 6 }, new int[] { 12, -3 }, new int[] { 1, 7 }, new int[] { 4, 2 })); // False


////5
////Challenge 5 - Easy - 2022-11-28
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 5 - Easy");

Console.WriteLine(E_Factorial.Factorial(3)); // 6
Console.WriteLine(E_Factorial.Factorial(6)); // 720
Console.WriteLine(E_Factorial.Factorial(12)); // 479001600
Console.WriteLine(E_Factorial.Factorial(5)); // 120



////6
////Challenge 6 - Easy - 2022-11-05
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 6 - Medium");

Console.WriteLine(M_GreaterThanOne.GreaterThanOne("1/2")); // false
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("7/4")); // true
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("10/10")); // false
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("12/30")); // false
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("35/31")); // true
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("11/27")); // false
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("42/32")); // true
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("16/16")); // true
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("38/41")); // false
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("45/43")); // true
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("13/38")); // false
Console.WriteLine(M_GreaterThanOne.GreaterThanOne("4/6")); // false



////7
////Challenge 7 - Easy - 2022-11-05
Console.WriteLine("\n");
Console.WriteLine("Challenge 7 - Easy");

Console.WriteLine(E_isIdentical.isIdentical("aaaaaa"));
Console.WriteLine(E_isIdentical.isIdentical("aabaaa"));
Console.WriteLine(E_isIdentical.isIdentical("ccccca"));
Console.WriteLine(E_isIdentical.isIdentical("kk"));




////int[] array = new int[5]; // array contains 5 int elements
////for (int counter = 0; counter < array.Length; ++counter)
////{
////    Console.WriteLine($"{counter,5}{array[counter],8}");
////}

//Console.WriteLine("\n");
//Console.WriteLine("\n");

////8
////Challenge 8 - Easy - 2022-11-08
//Console.WriteLine("\n");
//Console.WriteLine("Challenge 8 - Medium");

//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("eDaBiT"));



Console.ReadLine();


