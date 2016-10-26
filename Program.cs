using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 100, 100, 6, -9, 233, 2, 75, 6, 399, 0, -1, 41, 8838 };
            int min = 0, max = 0;

            if (num.Length % 2 == 0 && num.Length > 1)//如果陣列是偶數時的比較
            {
                max = min; min = num[0];

                for (int i = 0; i < num.Length; i += 2)
                {
                    if (num[i] <= num[i + 1])
                    {
                        if (num[i + 1] > max) max = num[i + 1];
                        if (num[i] < min) min = num[i];
                    }
                    else if (num[i] >= num[i + 1])
                    {
                        if (num[i] > max) max = num[i];
                        if (num[i + 1] < min) min = num[i + 1];
                    }
                }
            }
            else if (num.Length % 2 > 0 && num.Length > 1)//如果陣列是奇數時的比較
            {
                int temp = 0;
                min = num[0];
                max = num[1];
                if (min > max) { temp = max; max = min; min = temp; }
                for (int i = 2; i < num.Length - 1; i += 2)
                {
                    if (num[i] <= num[i + 1])
                    {
                        if (num[i + 1] > max) max = num[i + 1];
                        if (num[i] < min) min = num[i];
                    }
                    else if (num[i] >= num[i + 1])
                    {
                        if (num[i] > max) max = num[i];
                        if (num[i + 1] < min) min = num[i + 1];
                    }
                }
                if (num[num.Length - 1] > max) { max = num[num.Length - 1]; }
                else if (num[num.Length - 1] < min) { min = num[num.Length - 1]; }

            }
            else if (num.Length == 1)//如果陣列只有一個
            {
                max = min = num[0];
            }

            System.Console.WriteLine("最大值：{0}\t最小值：{1}", max, min);
            System.Console.Read();



        }
    }
}
