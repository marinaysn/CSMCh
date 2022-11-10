using marCh;

//1
//Challenge 1 - Very Easy - 2022-11-05
Console.WriteLine("Challenge 1 - Very Easy");

int[] abc = VEArrayOfMultiples.ArrayOfMultiples(7, 5);

foreach (int i in abc)
{
    Console.Write(i + " ");
}

//2
//Challenge 2 - Hard - 2022-11-05
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 2 - Hard");

string mar = HReverseAndNot.ReverseAndNot5(12345);

Console.WriteLine(mar);

//3
//Challenge 3 - Easy - 2022-11-05
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 3 - Easy");

Console.WriteLine(EMonthName.MonthName(3));
Console.WriteLine(EMonthName.MonthName(13));
Console.WriteLine(EMonthName.MonthName(7));

//4
//Challenge 4 - Easy - 2022-11-05
//Console.WriteLine("\n\n");
//Console.WriteLine("Challenge 4 - VeryHard");



Console.WriteLine(VHFibonacci.FiboWord(3));
Console.WriteLine(VHFibonacci.FiboWord2(7));
Console.WriteLine(VHFibonacci.FiboWord(1));


//5
//Challenge 5 - Easy - 2022-11-06
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 5 - Easy");

   // double[] items = { 1, 2, 3, 4, 5 };

    double[] arr = EFindMinMax.FindMinMax(new double[] { 1, 2, 3, 4, 5 });

    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }


//6
//Challenge 6 - Easy - 2022-11-05
Console.WriteLine("\n\n");
Console.WriteLine("Challenge 6 - Medium");

Console.WriteLine(MReverseCase.ReverseCase("Happy Birthday"));
Console.WriteLine(MReverseCase.ReverseCase("MANY THANKS"));
Console.WriteLine(MReverseCase.ReverseCase("Happy Birthday"));
Console.WriteLine(MReverseCase.ReverseCase("sPoNtAnEoUs"));
Console.WriteLine(MReverseCase.ReverseCase("1234567890"));
Console.WriteLine(MReverseCase.ReverseCase("eXCELLENT, yOuR mAJESTY"));



//7
//Challenge 7 - Easy - 2022-11-05
Console.WriteLine("\n");
Console.WriteLine("Challenge 7 - Hard");

Console.WriteLine(HWeekAfter.WeekAfter("12/03/2020"));
Console.WriteLine(HWeekAfter.WeekAfter("21/12/1989"));
Console.WriteLine(HWeekAfter.WeekAfter("01/01/2000"));
Console.WriteLine(HWeekAfter.WeekAfter("29/12/2022"));



//int[] array = new int[5]; // array contains 5 int elements
//for (int counter = 0; counter < array.Length; ++counter)
//{
//    Console.WriteLine($"{counter,5}{array[counter],8}");
//}

Console.WriteLine("\n");
Console.WriteLine("\n");

//7
//Challenge 8 - Easy - 2022-11-08
Console.WriteLine("\n");
Console.WriteLine("Challenge 8 - Medium");

Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("eDaBiT"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("eQuINoX"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("determine"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("determine12"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("STRIKE"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("$#@%"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("sUn"));
Console.WriteLine(MIndexOfCapitals.IndexOfCapitals("test"));


Console.ReadLine();


