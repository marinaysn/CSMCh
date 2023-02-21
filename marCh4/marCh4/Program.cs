using marCh4;
using System;

//1
////Challenge 1 - Very Easy - 2023-01-19
//Console.WriteLine("Challenge 1 - Very Easy");

//Console.WriteLine(VEHackerSpeak.HackerSpeak("javascript is cool")); //"j4v45cr1pt 15 c00l"
//Console.WriteLine(VEHackerSpeak.HackerSpeak("programming is fun")); //"pr0gr4mm1ng 15 fun"
//Console.WriteLine(VEHackerSpeak.HackerSpeak("become a coder")); //"b3c0m3 4 c0d3r"



////2
////Challenge 2 - Easy - 2023-01-20
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 2 - Easy");


//Console.WriteLine(ESameCase.SameCase("hello")); //true
//Console.WriteLine(ESameCase.SameCase("HELLO")); //true
//Console.WriteLine(ESameCase.SameCase("Hello")); //false
//Console.WriteLine(ESameCase.SameCase("ketcHUp")); //false



//////3
//////Challenge 3 - Medium - 2023-01-20
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 3 - Medium");

//Console.WriteLine(MCountOnes.CountOnes(0)); // 0 
//Console.WriteLine(MCountOnes.CountOnes(100)); //3
//Console.WriteLine(MCountOnes.CountOnes(999)); // 8
//Console.WriteLine(MCountOnes.CountOnes(3)); // 2

////4
////Challenge 4 - Easy - 2022-11-05
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 4 - VeryHard");

Console.WriteLine(MatTest.fibonacciBad(3));
Console.WriteLine(MatTest.fibonacciBad(5));
Console.WriteLine(MatTest.fibonacciBad(7));


Console.WriteLine(MatTest.fibonacciGood(3));
Console.WriteLine(MatTest.fibonacciGood(5));
Console.WriteLine(MatTest.fibonacciGood(7));



////5
//Challenge 5 - Expter - 2023-02-20
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 5 - Expert");

//// double[] items = { 1, 2, 3, 4, 5 };


Console.WriteLine(ExSolve.Solve(new int[] { 7,2 })); //5
Console.WriteLine(ExSolve.Solve(new int[] { 2, 7, 3 })); //-2
Console.WriteLine(ExSolve.Solve(new int[] { 1000, 1000, 1000, 1000, 1000 })); //1000
Console.WriteLine(ExSolve.Solve(new int[] { 823, 912, 345, 100000, 867, 222, 991, 3, 40000 })); // ‐58111
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5 })); //3
Console.WriteLine(ExSolve.Solve(new int[] { 7, 7, 7, 7, 7, 7, 80, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 })); //-66
Console.WriteLine(ExSolve.Solve(new int[] { 7, 7, 7, 7, 7, 7, 7, 80, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 })); // 73
Console.WriteLine(ExSolve.Solve(new int[] { 91, 56, 23, 45, 87, 65, 45, 45, 78, 23, 20, 41, 17, 54, 51, 51, 94, 62, 74, 42, 76, 76  })); // 96
Console.WriteLine(ExSolve.Solve(new int[] { 92834, 95461, 15911, 56189, 6369, 80545, 31811, 51263, 30076, 68867, 36905, 32499, 59799, 334, 82991, 46636, 98741, 66601  })); // 42958
Console.WriteLine(ExSolve.Solve(new int[] { 129  })); //  129
Console.WriteLine(ExSolve.Solve(new int[] { 35463, 88121, 4362, 94457, 86235, 83680, 72686, 6003, 93069, 2015, 10436, 2139, 93162, 30380, 19067, 76335, 78941, 48620, 55887, 15679  })); // 101879
Console.WriteLine(ExSolve.Solve(new int[] { 19335, 97643, 11468, 86267, 79718, 59584, 12129, 52642, 86575, 62307, 11545, 52658, 72377, 39986, 74850, 1992, 86928  })); // 1846
Console.WriteLine(ExSolve.Solve(new int[] { 91883, 97793, 54567, 64714, 98624  })); // 82567
Console.WriteLine(ExSolve.Solve(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1  })); // 0
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 11, 11, 11, 111, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 112, 312, 312, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 231, 31, 312  })); // 316
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 })); // 25
Console.WriteLine(ExSolve.Solve(new int[] { 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45  })); // 1995
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3  })); // 1
Console.WriteLine(ExSolve.Solve(new int[] { 9, 100, 1, 8 })); // 98
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 66, 5, 4, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 6, 5, 4, 5, 6, 3, 4, 4, 5, 6, 3, 4, 5, 6, 3, 4, 5, 6, 3, 4, 5, 6, 3, 4, 5, 6  })); // 68
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 1, 2, 3, 4, 65, 67, 2, 3, 4, 7, 2, 3, 4, 6, 6, 7, 2, 3, 4, 7, 78, 8, 82, 2, 3, 4, 7, 2, 2, 34, 4, 6, 7, 3, 2  })); // 128
Console.WriteLine(ExSolve.Solve(new int[] { 100, 10, 10 })); // 100
Console.WriteLine(ExSolve.Solve(new int[] { 1 })); // 1
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 3, 5, 4, 6, 7, 5, 6, 10, 2, 5, 4, 3, 4, 5, 6, 7, 9, 10  })); // 28
Console.WriteLine(ExSolve.Solve(new int[] { 6, 4, 3, 5, 8, 8  })); // 2
Console.WriteLine(ExSolve.Solve(new int[] { 1, 5, 20, 2, 1  })); // -13
Console.WriteLine(ExSolve.Solve(new int[] { 1, 2, 3, 4, 5, 6, 6, 7, 8, 767, 765, 111, 76576, 5, 64, 654, 64, 7, 7657, 76575, 64, 65, 6454, 64, 654, 65464, 7, 5435, 65, 746, 7, 546, 7, 654, 7, 5435, 547, 6, 6, 7, 6547, 7654, 6, 754, 54353, 65, 7, 8 })); // 118231

////6
////Challenge 6 - Easy - 2022-11-05
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 6 - Medium");

//Console.WriteLine(MReverseCase.ReverseCase("Happy Birthday"));
//Console.WriteLine(MReverseCase.ReverseCase("MANY THANKS"));
//Console.WriteLine(MReverseCase.ReverseCase("Happy Birthday"));
//Console.WriteLine(MReverseCase.ReverseCase("sPoNtAnEoUs"));
//Console.WriteLine(MReverseCase.ReverseCase("1234567890"));
//Console.WriteLine(MReverseCase.ReverseCase("eXCELLENT, yOuR mAJESTY"));



////7
////Challenge 7 - Easy - 2022-11-05
//Console.WriteLine("\n");
//Console.WriteLine("Challenge 7 - Hard");

//Console.WriteLine(HWeekAfter.WeekAfter("12/03/2020"));
//Console.WriteLine(HWeekAfter.WeekAfter("21/12/1989"));
//Console.WriteLine(HWeekAfter.WeekAfter("01/01/2000"));
//Console.WriteLine(HWeekAfter.WeekAfter("29/12/2022"));



////int[] array = new int[5]; // array contains 5 int elements
////for (int counter = 0; counter < array.Length; ++counter)
////{
////    Console.WriteLine($"{counter,5}{array[counter],8}");
////}

//Console.WriteLine("\n");
//Console.WriteLine("\n");

////7
////Challenge 8 - Easy - 2022-11-08
//Console.WriteLine("\n");
//Console.WriteLine("Challenge 8 - Medium");

//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("eDaBiT"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("eQuINoX"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("determine"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("determine12"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("STRIKE"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("$#@%"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("sUn"));
//Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("test"));


Console.ReadLine();
