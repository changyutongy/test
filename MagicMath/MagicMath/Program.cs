//#define quicksort
#define spider

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMath
{
				class Program
				{
								static void Main(string[] args)
								{

#if quicksort
												#region quick sort
												List<int> numbers = new List<int>() { 12, 325, 59, 3, 452, 4, 734, 7, 5 };
												Console.WriteLine("排序前。。。。。");
												PrintNumbers(numbers);
												QuickSort.Sort(numbers, 0, numbers.Count - 1);
												Console.WriteLine("\r\n排序后。。。。。");
												PrintNumbers(numbers);
												#endregion
#endif

#if spider
												string url = "http://www.baidu.com";
												string responseContent = SpiderPage.GetData(url).Result;
												Console.WriteLine(responseContent);
#endif


												Console.ReadLine();
								}

								static void PrintNumbers(List<int> numbers)
								{
												foreach (var item in numbers)
												{
																Console.Write(item + ",");
												}
								}
				}
}
