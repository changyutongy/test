using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMath
{
				/// <summary>
				/// quick sort
				/// </summary>
				public static class QuickSort
				{
								public static void Sort(List<int> ints, int left, int right)
								{
												if (left > right)
																return;

												int temp = ints[left];
												int x = left;
												int y = right;
												while (x < y)
												{ 
																while (x < y && ints[y] >= temp)
																				y--;

																while (x < y && ints[x] <= temp)
																				x++;

																if (x < y)
																{
																				int t = ints[x];
																				ints[x] = ints[y];
																				ints[y] = t;
																}
												}

												ints[left] = ints[x];
												ints[x] = temp;

												Sort(ints, left, x - 1);
												Sort(ints, x + 1, right);
												return;
								}
				}
}
