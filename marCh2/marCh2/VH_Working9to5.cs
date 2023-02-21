using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh2
{
    public class VH_Working9to5
    {

        public static string OverTime(double[] arr)
        {

            double start = arr[0];
            double end = arr[1];
            double rate = arr[2];
            double overtimeRate = arr[3];
            double overTimeAM = (start < 9) ? 9 - start : (start > 17) ? 17  - start: 0;
            double overTimePM = (end > 17) ? end - 17 : 0;

            double regulatHours = end - start - overTimeAM - overTimePM;
            double regularPay = regulatHours * rate;
            double overtime = overTimeAM + overTimePM;
            double overtimePay = overtime * (rate * overtimeRate);

            return string.Format("${0:N}", (regularPay + overtimePay));

        }


        public static string OverTime1(double[] arr)
        {
            var normalHoursPay = Math.Max(0, Math.Min(17, arr[1]) - arr[0]) * arr[2];
            var overtimeHoursPay = Math.Max(arr[1] - Math.Max(17, arr[0]), 0) * arr[2] * arr[3];
            return $"${normalHoursPay + overtimeHoursPay:0.00}";
        }


        public static string OverTime2(double[] arr)
        {
            var startTime = arr[0];
            var endTime = arr[1];
            var hourlyRate = arr[2];
            var overtimeMultiplier = arr[3];

            if (startTime > endTime)
                throw new ArgumentException($"The start time must be lower than the end time");

            var baseHoursWorked = 0.0;
            var overTimeHoursWorked = 0.0;

            // worked normal hours and overtime hours
            if (endTime > 17 && startTime < 17)
            {
                baseHoursWorked = 17 - startTime;
                overTimeHoursWorked = endTime - 17;
            }
            // worked only overtime hours
            else if (endTime > 17 && startTime >= 17)
            {
                overTimeHoursWorked = endTime - startTime;
            }
            // worked only normal hours
            else
                baseHoursWorked = endTime - startTime;

            var totalEarned = baseHoursWorked * hourlyRate + overTimeHoursWorked * hourlyRate * overtimeMultiplier;
            return $"${totalEarned.ToString("##.#0")}";
        }

        public static string OverTime3(double[] arr)
        {
            var ot = Math.Min(arr[1] - arr[0], Math.Max(0, arr[1] - 17));
            var pay = (ot * arr[3] + (arr[1] - arr[0] - ot)) * arr[2];
            return $"${pay:0.00}";
        }

        public static string OverTime4(double[] arr)
        {
            double[] hours = { arr[1] > 17 ? (arr[0] > 17 ? 0 : 17 - arr[0]) : arr[1] - arr[0], Math.Max(0, (arr[0] > 17 ? arr[1] - arr[0] : arr[1] - 17)) };
            return ((hours[1] * arr[3] + hours[0]) * arr[2]).ToString("c", new System.Globalization.CultureInfo("en-US"));
        }

        public static string OverTime5(double[] arr)
        {
            var startingTime = arr[0];
            var endTime = arr[1];
            var rate = arr[2];
            var multiplier = arr[3];
            double payment;

            if (endTime <= 17d)
            {
                payment = (endTime - startingTime) * rate;
            }
            else
            {
                if (startingTime < 17)
                {
                    payment = ((17 - startingTime) + (endTime - 17) * multiplier) * rate;
                }
                else
                {
                    payment = (endTime - startingTime) * multiplier * rate;
                }
            }
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            return payment.ToString("C2", culture);
        }

        public static string OverTime6(double[] arr)
        {
            foreach (double d in arr)
                Console.WriteLine(d);
            double start = arr[0];
            double end = arr[1];
            double rate = arr[2];
            double multi = arr[3];
            double payment = 0;
            if (end > 17 && start < 17)
            {
                payment += (end - 17) * rate * multi;
                end = 17;
                payment += (end - start) * rate;

            }
            else if (end > 17 && start > 17) payment += (end - start) * rate * multi;

            else payment += (end - start) * rate;
            string result = "$" + String.Format("{0:0.00}", payment);

            return result;
        }

    }
}


/*
 * 
 * Write a function that calculates overtime and pay associated with overtime.

Working 9 to 5: regular hours
After 5pm is overtime
Your function gets an array with 4 values:

Start of working day, in decimal format, (24-hour day notation)
End of working day. (Same format)
Hourly rate
Overtime multiplier
Your function should spit out:

$ + earned that day (rounded to the nearest hundreth)
Examples
OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
2nd example explained:

From 16 to 17 is regular, so 1 * 30 = 30
From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
30 + 54 = $84.00
 */
