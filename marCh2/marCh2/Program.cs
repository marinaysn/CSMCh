using marCh2;

//1
//Challenge 1 - Very Hard - 2022-11-20
Console.WriteLine("Challenge 1 - Very Hard");

Console.WriteLine(VH_Working9to5.OverTime(new double[] { 9, 17, 30, 1.5 })); //"$240.00"
Console.WriteLine(VH_Working9to5.OverTime(new double[] { 16, 18, 30, 1.8 })); // "$84.00"
Console.WriteLine(VH_Working9to5.OverTime(new double[] { 13.25, 15, 30, 1.5 })); // "$52.50"
Console.WriteLine(VH_Working9to5.OverTime(new double[] { 18, 20, 32.5, 2 })); // "$130.00"


//foreach (int i in abc)
//{
//    Console.Write(i + " ");
//}

//2
//Challenge 2 - Very Hard - 2022-11-20
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 2 - Very Hard");

Console.WriteLine(VH_PaulCipher.PaulCipher("muBas41r")); //"MHWCT41K"
Console.WriteLine(VH_PaulCipher.PaulCipher("A1rForce")); // "A1SXUGUH"
Console.WriteLine(VH_PaulCipher.PaulCipher("MNUN")); // "MNUN"
Console.WriteLine(VH_PaulCipher.PaulCipher("MATT")); // "MNUN"
Console.WriteLine(VH_PaulCipher.PaulCipher("4elen10ve")); // "4EQQS10JA"
Console.WriteLine(VH_PaulCipher.PaulCipher("He1lo")); // "HM1QA"
Console.WriteLine(VH_PaulCipher.PaulCipher("p4K1St4n")); // "P4A1DM4H"
Console.WriteLine(VH_PaulCipher.PaulCipher(" The quick brown fox jumps over the lazy dog. ")); // " TBM VLDLN MTGLK TUM HEHCI HKAW LBM QMAY CSV. "
Console.WriteLine(VH_PaulCipher.PaulCipher("aNNa")); // "AOBO"
Console.WriteLine(VH_PaulCipher.PaulCipher("5ddc4ddf-7a47-44d3-8eda-3171860dc938")); // "5DHG4GHJ-7G47-44E3-8IIE-3171860EG938"




//3
//Challenge 3 - Easy - 2022-11-20
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 3 - Medium");

Console.WriteLine(M_gcd.gcd(32, 8)); // 8
Console.WriteLine(M_gcd.gcd(8, 12)); // 4
Console.WriteLine(M_gcd.gcd(32, 0)); // 32
Console.WriteLine(M_gcd.gcd(17, 13)); // 1

////4
////Challenge 4 - Easy - 2022-11-21
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 4 - Medium");

Console.WriteLine(M_collatz.collatz(1)); // 1
Console.WriteLine(M_collatz.collatz(3)); // 7
Console.WriteLine(M_collatz.collatz(10)); // 6
Console.WriteLine(M_collatz.collatz(6)); // 8
Console.WriteLine(M_collatz.collatz(345)); // 125
Console.WriteLine(M_collatz.collatz(72)); // 22
Console.WriteLine(M_collatz.collatz(1)); // 1



////5
////Challenge 5 - Easy - 2022-11-06
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 5 - Easy");

//// double[] items = { 1, 2, 3, 4, 5 };

//double[] arr = EFindMinMax.FindMinMax(new double[] { 1, 2, 3, 4, 5 });

//foreach (int i in arr)
//{
//    Console.Write(i + " ");
//}


////6
////Challenge 6 - Easy - 2022-11-05
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 6 - Medium");

//Console.WriteLine(MReverseCase.ReverseCase("Happy Birthday"));




////7
////Challenge 7 - Easy - 2022-11-05
//Console.WriteLine("\n");
//Console.WriteLine("Challenge 7 - Hard");

//Console.WriteLine(HWeekAfter.WeekAfter("12/03/2020"));




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


