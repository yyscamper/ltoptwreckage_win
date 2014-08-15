using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LtOptWreckageGUI
{
    public class Wreckage
    {
        public int Value;
        public int MaxNum;
        public int CurrNum;
        public int BodyPoint;

        public Wreckage(int val, int max)
        {
            Value = val;
            MaxNum = max;
            CurrNum = 0;

            if ((val - 4816) % 1208 == 0)
            {
                BodyPoint = 20;
            }
            else if ((val - 2656) % 668 == 0)
            {
                BodyPoint = 12;
            }
            else if ((val - 1216) % 308 == 0)
            {
                BodyPoint = 6;
            }
            else
            {
                BodyPoint = 0;
            }
        }
    }

    public class WreckageResult
    {
        public int[] Nums;
        public int Value;
        public int EstimateBodyPoint;

        public WreckageResult(int[] nums, int val)
        {
            Nums = nums;
            Value = val;
        }

        public int GetNumOfKinds()
        {
            int n = 0;
            foreach (int i in Nums)
                n += (i != 0 ? 1 : 0);
            return n;
        }

        public int GetTotalNumOfWreckage()
        {
            int n = 0;
            foreach (int i in Nums)
                n += i;
            return n;
        }

        public int UpdateBodayPoint(Wreckage[] wreckages)
        {
            int n = 0;
            for (int i = 0; i < wreckages.Length; i++)
            {
                n += wreckages[i].BodyPoint * Nums[i];
            }
            EstimateBodyPoint = n / 2;
            return EstimateBodyPoint;
        }
    }

    public enum ResultOrder : int
    {
        Delta = 0,
        TotalNum = 1,
        BodyPoint = 2
    }

    public class WreckageCalculator
    {
        public static String GetResultString(WreckageResult result, Wreckage[] wreckages, int target)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < wreckages.Length; i++)
            {
                if (result.Nums[i] == 1)
                {
                    //sb.Append(wreckages[i].Value + " + ");
                    sb.Append(String.Format("{0:D}*{1:D} + ", wreckages[i].Value, result.Nums[i]));
                }
                else if (result.Nums[i] >= 2)
                {
                    sb.Append(String.Format("{0:D}*{1:D} + ", wreckages[i].Value, result.Nums[i]));
                }
            }

            sb.Remove(sb.Length - 3, 3);
            return sb.ToString();
        }

        private static int CompareWreckageResultByDelta(WreckageResult r1, WreckageResult r2)
        {
            if (r1.Value < r2.Value)
                return -1;
            else if (r1.Value > r2.Value)
                return 1;
            else
            {
                if (r1.EstimateBodyPoint < r2.EstimateBodyPoint)
                {
                    return -1;
                }
                else if (r1.EstimateBodyPoint > r2.EstimateBodyPoint)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private static int CompareWreckageResultByTotalNum(WreckageResult r1, WreckageResult r2)
        {
            if (r1.GetTotalNumOfWreckage() < r2.GetTotalNumOfWreckage())
                return -1;
            else if (r1.GetTotalNumOfWreckage() > r2.GetTotalNumOfWreckage())
                return 1;
            else
            {
                if (r1.Value < r2.Value)
                {
                    return -1;
                }
                else if (r1.Value > r2.Value)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private static int CompareWreckageResultByBodyPoint(WreckageResult r1, WreckageResult r2)
        {
            if (r1.EstimateBodyPoint < r2.EstimateBodyPoint)
                return -1;
            else if (r1.EstimateBodyPoint > r2.EstimateBodyPoint)
                return 1;
            else
            {
                if (r1.Value < r2.Value)
                {
                    return -1;
                }
                else if (r1.Value > r2.Value)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void ShowResults(List<WreckageResult> results, Wreckage[] wreckages, int target)
        {
            Console.WriteLine("目标经验: " + target);
            Console.WriteLine("|-----------------------------------------------------------------------------");
            Console.WriteLine("|   #  |  多余经验 | 残骸组合");
            Console.WriteLine("|-----------------------------------------------------------------------------");
            int index = 1;
            Sort(results, ResultOrder.Delta);
            foreach (WreckageResult result in results)
            {
                String str = GetResultString(result, wreckages, target);
                Console.WriteLine(String.Format("| {0,3}  |    {1,3}    |  {2}", index, result.Value - target, str));
                index++;
            }
        }

        public static List<WreckageResult> Sort(List<WreckageResult> results, ResultOrder order)
        {
            if (results == null || results.Count <= 1)
                return results;

            if (order == ResultOrder.BodyPoint)
            {
                results.Sort(CompareWreckageResultByBodyPoint);
            }
            else if (order == ResultOrder.TotalNum)
            {
                results.Sort(CompareWreckageResultByTotalNum);
            }
            else
            {
                results.Sort(CompareWreckageResultByDelta);
            }
            return results;
        }

        public static List<WreckageResult> DoCalc(Wreckage[] wreckages, int target, int allowedError)
        {
            int calValue = 0;
            List<WreckageResult> results = new List<WreckageResult>();
            int upLimit = target + allowedError;
            int temp;

            for (int i = 0; i < wreckages.Length; i++)
            {
                wreckages[i].CurrNum = 0;

                temp = upLimit / wreckages[i].Value;
                if (wreckages[i].MaxNum > temp)
                    wreckages[i].MaxNum = temp;
            }

            while (true)
            {
            next_round:
                if (wreckages[wreckages.Length - 1].CurrNum > wreckages[wreckages.Length - 1].MaxNum) //finished all scan
                {
                    return results;
                }

                while (wreckages[0].CurrNum <= wreckages[0].MaxNum)
                {
                    calValue = 0;
                    for (int x = 0; x < wreckages.Length; x++)
                    {
                        calValue += (wreckages[x].CurrNum * wreckages[x].Value);
                    }

                    if (calValue >= target && calValue < target + allowedError)
                    {
                        int[] nums = new int[wreckages.Length];
                        for (int y = 0; y < wreckages.Length; y++)
                        {
                            nums[y] = wreckages[y].CurrNum;
                        }
                        WreckageResult r = new WreckageResult(nums, calValue);
                        r.UpdateBodayPoint(wreckages);
                        results.Add(r);
                    }

                    wreckages[0].CurrNum++;
                }

                if (wreckages.Length == 1)
                {
                    return results;
                }

                wreckages[0].CurrNum = 0;

                for (int i = 1; i < wreckages.Length; i++)
                {
                    if (++wreckages[i].CurrNum > wreckages[i].MaxNum)
                    {
                        //shift right one
                        if (i != (wreckages.Length - 1))
                            wreckages[i].CurrNum = 0;

                        for (int j = i + 1; j < wreckages.Length; j++)
                        {
                            if (++wreckages[j].CurrNum <= wreckages[j].MaxNum)
                            {
                                goto next_round;
                            }
                            else
                            {
                                if (j != (wreckages.Length - 1))
                                    wreckages[j].CurrNum = 0;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        /*
        static void Main(string[] args)
        {
            Wreckage[] wreckages = new Wreckage[] 
            {
                new Wreckage(4660, 10),
                new Wreckage(4816, 6),
                new Wreckage(5328, 10),
                new Wreckage(6024, 6),
                new Wreckage(7232, 6),
                new Wreckage(9648, 6),
                new Wreckage(8440, 7),
                new Wreckage(400, 1)
            };

            int[] targets = new int[] { 21360, 37800, 59160 };
            int allowedError = 400;

            for (int i = 0; i < targets.Length; i++)
            {
                List<WreckageResult> results = DoCalc(wreckages, targets[i], allowedError);
                Console.WriteLine("=====================================================");
                ShowResults(results, wreckages, targets[i]);
            }

            Console.ReadKey();
        }
        */
    }
}
