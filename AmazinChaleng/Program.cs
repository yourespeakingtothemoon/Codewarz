using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Student s1 = new Student();
s1.rank = 1;
Student s2 = new Student();
s2.rank = 4;
Student s3 = new Student();
s3.rank = 5;
Student s4 = new Student();
s4.rank = 7;
Student s5 = new Student();
s5.rank = 22;

Student[] students = new Student[] {s3, s4, s5, s1,s2 };

Bezos b = new Bezos(students);

Console.WriteLine(b.imbalance(2));
Console.WriteLine(b.imbalance(3));
Console.WriteLine(b.imbalance(4));
Console.WriteLine(b.imbalance(5));


//Amazon Academy recently organized a scholarship test on its platform. A total of n students participated in the test. Each student received a unique roll number, i. Each student's rank is stored at rank[i]. Each student gets a unique rank, so rank is a permutation of values 1 through n.

//For improved collaboration, the students are to be divided into groups. Use the following rules to find the imbalance of a group of students.

//• A group has k students where 1 ≤ k ≤n.

//• Groups are formed of k students in ranks with consecutive roll numbers, i.e., i. (i + 1)... (i + k - 1).

//• The ranks of the students in a group are then sorted

//ascending to an array, here named sorted_rank.

//• The imbalance of the group is then defined as the number of students j, who are more than 1 rank beneath the rank of the student just ahead of them, i.e, sorted_rank[j] - sorted_rank[j-1]> 1.

//For example, the ranks in a group are [1, 5, 4] so sorted_rank = [1, 4, 5].

//• 4-1=3, and 3>1. This adds 1 to the imbalance. ⚫5-4=1, and 1 = 1. This does not add to the imbalance.

//The imbalance is 1.

//Given the ranks of n students, find the total sum of the imbalance of all possible groups.

struct Student
{
	public int roll;
	public int rank;
}

class Bezos
{
	public Bezos(Student[] s)
	{
		students = s;
	}

	private Student[] SortByRank(Student[] s)
	{
		Student[] sorted = s;
		sort.MergeSort(ref sorted);
		return sorted;
	}

	private long rankSum(int n, Student[] group)
	{
		long sum = 0;
		for (int i = 0; i < n; i++)
		{
			sum += group[i].rank;
		}
		return sum;
	}

	public long imbalance(int n)
	{
		//That Did NOT Work lol.
		


		
	//Student[] sorted = SortByRank();
	Student[] group = new Student[n];
		for (int i = 0; i < n; i++)
		{
			group[i] = students[i];
		}
		group = SortByRank(group);
		int ret = 0;
		for(int i =1; i < group.Length; i++)
		{
			if (group[i].rank - group[i-1].rank >= 2)
			{
				ret++;
			}
		}
		return ret;

		//long sum = rankSum(n,group);
		//float avg = averageRank(n, group);
		//float im = avg - (float)sum;
		//if (im < 0)
		//{
		//	return 0;
		//}

		//return (long)(sum / inverse(im));
	}

	private float averageRank(int n, Student[] group)
	{
		return (float)rankSum(n, group) / n;
	}

	private float inverse(float n)
	{
		return 1 / n;
	}



	public Student[] students;
}



class sort
{
	//Merge Attempt Two
	public static void MergeSort(ref Student[] c)
	{

		Student[] l;
		Student[] r;

		if (c.Length > 1)
		{
			l = new Student[c.Length / 2];
			r = new Student[c.Length - l.Length];
			//  int sp = c.Length - r.Length;

			for (int i = 0; i < l.Length; i++)
			{
				l[i] = c[i];
			}
			int sp = l.Length;
			for (int i = 0; i < r.Length; i++)
			{
				r[i] = c[sp];
				sp++;
			}

			MergeSort(ref l);
			MergeSort(ref r);
			CombineStep(ref c, l, r);
		}
		else { }

	}

	private static void CombineStep(ref Student[] c, Student[] l, Student[] r)
	{
		int rdx = 0;
		int ldx = 0;

		int idx = 0;

		while (ldx < l.Length && rdx < r.Length)
		{
			if (l[ldx].rank.CompareTo(r[rdx].rank) <= 0)
			{
				c[idx] = l[ldx];
				ldx++;
			}
			else
			{
				c[idx] = r[rdx];
				rdx++;
			}
			idx++;
		}

		while (ldx < l.Length)
		{
			c[idx] = l[ldx];
			ldx++;
			idx++;
		}

		while (rdx < r.Length)
		{
			c[idx] = r[rdx];
			rdx++;
			idx++;
		}
	}

}


//CITATION: THIS IS FROM A PREVIOUS SORTING ALGORITHM PROJECT I WROTE USED AS A REFERENCE 
namespace SortingLibrary
{
	public class Sorter<T> where T : IComparable<T>
	{

		public static void BubbleSort(ref T[] c)
		{
			int idx1, idx2;

			for (idx1 = 0; idx1 < c.Length - 1; idx1++)
			{
				for (idx2 = 0; idx2 < c.Length - idx1 - 1; idx2++)
				{
					if (c[idx2].CompareTo(c[idx2 + 1]) > 0)
					{
						SwapValues(ref c[idx2], ref c[idx2 + 1]);
					}
				}
			}

		}

		public static void SelectionSort(ref T[] c)
		{
			int idx1, min, idx2;
			for (idx1 = 0; idx1 < c.Length - 1; idx1++)
			{
				min = idx1;
				for (idx2 = idx1 + 1; idx2 < c.Length; idx2++)
				{
					if (c[idx2].CompareTo(c[min]) < 0)
					{
						min = idx2;
					}
				}
				SwapValues(ref c[idx1], ref c[min]);
			}

		}

		public static void InsertionSort(ref T[] c)
		{
			int idx1, idx2;
			T key;
			for (idx1 = 1; idx1 < c.Length; idx1++)
			{
				key = c[idx1];
				idx2 = idx1 - 1;
				while (idx2 >= 0 && c[idx2].CompareTo(key) > 0)
				{
					c[idx2 + 1] = c[idx2];
					idx2 = idx2 - 1;
				}
				c[idx2 + 1] = key;

			}

		}





		/* code that did not work
		 public static void QuickSort(ref T[] c, int floor, int ceiling)
		 {
			 //this is called the Lomuto partition scheme apparently
			 if (floor < ceiling)
			 {
				 int part = QuickPartition(ref c, floor, ceiling);

				 QuickSort(ref c, floor, part - 1);
				 QuickSort(ref c, part + 1, ceiling);
			 }
		 }


		 public static int QuickPartition(ref T[] c, int floor, int ceiling)
		 {
			 T piv = c[ceiling];
			 int idx = floor - 1;
			 for (int i = floor; i < ceiling - 1; i++)
			 {
				 if (c[i].CompareTo(piv) <= 0)
				 {
					 idx++;
					 SwapValues(ref c[idx], ref c[i]);
				 }
			 }
			 idx += 1;
			 SwapValues(ref c[idx], ref c[ceiling]);
			 //heres to hoping I avoid a Stack Overflow....
			 return idx;
		 }*/


		//Reattempt at a QSort with that partition scheme i read about on wikipedia

		public static void QuickSort(ref T[] c, int f, int cel)
		{
			if (f < cel)
			{
				Random rand = new Random();
				int pivotIndex = rand.Next(f, cel);
				SwapValues(ref c[pivotIndex], ref c[cel]);
				int part = QuickPart(ref c, f, cel);
				QuickSort(ref c, f, part - 1);
				QuickSort(ref c, part + 1, cel);
			}
		}

		private static int QuickPart(ref T[] c, int f, int cel)
		{
			T piv = c[cel];
			int idx = f - 1;

			for (int i = f; i < cel; i++)
			{
				if (c[i].CompareTo(piv) <= 0)
				{
					idx++;
					SwapValues(ref c[idx], ref c[i]);
				}
			}
			SwapValues(ref c[idx + 1], ref c[cel]);
			return idx + 1;
		}
		//"ITS WORKING" -Jake Lloyd
		/*More code thatno work (Merge this time)
				//Merge time (sunglass emoji)
				public static void MergeSort(T[] c)
				{

					if (c.Length > 1)
					{
						T[][] arys = MergeSplitStep(c);

						MergeSort(arys[0]);
						MergeSort(arys[1]);
						c = MergeCombineStep(arys[0], arys[1]);

					}
					else { }

				}

				private static T[] MergeCombineStep(T[] l, T[] r)
				{
					T[] ret = new T[l.Length + r.Length - 1];
					int ldx = 0;
					int rdx = 0;
					int idx = 0;
					while (ldx < l.Length && rdx < r.Length)
					{
						if (l[ldx].CompareTo(r[rdx])>=0)
						{
							ret[idx] = l[ldx];
							ldx++;
						}
						else
						{
							ret[idx] = r[rdx];
							rdx++;
						}
						idx++;
					}

					while (ldx < l.Length)
					{
						ret[idx] = l[ldx];
						ldx++;
						idx++;
					}

					while (rdx < r.Length)
					{
						ret[idx] = r[rdx];
						rdx++;
						idx++;
					}

					return ret;
				}

				private static T[][] MergeSplitStep(T[] c)
				{
					T[] tempL = new T[c.Length / 2];
					int idx = 0;
					for (int i = 0; i < tempL.Length; i++)
					{
						tempL[i] = c[i];
							idx = i;
					}
					T[] tempR = new T[c.Length - tempL.Length +1];
					for(int i = 0; idx < c.Length-1; i++)
					{
						tempR[i] = c[idx + 1];
						idx++;
					}
					T[][] ret = { tempL, tempR };
					return ret;

				}

			*/

		//Merge Attempt Two
		public static void MergeSort(ref T[] c)
		{

			T[] l;
			T[] r;

			if (c.Length > 1)
			{
				l = new T[c.Length / 2];
				r = new T[c.Length - l.Length];
				//  int sp = c.Length - r.Length;

				for (int i = 0; i < l.Length; i++)
				{
					l[i] = c[i];
				}
				int sp = l.Length;
				for (int i = 0; i < r.Length; i++)
				{
					r[i] = c[sp];
					sp++;
				}

				MergeSort(ref l);
				MergeSort(ref r);
				CombineStep(ref c, l, r);
			}
			else { }

		}

		private static void CombineStep(ref T[] c, T[] l, T[] r)
		{
			int rdx = 0;
			int ldx = 0;

			int idx = 0;

			while (ldx < l.Length && rdx < r.Length)
			{
				if (l[ldx].CompareTo(r[rdx]) <= 0)
				{
					c[idx] = l[ldx];
					ldx++;
				}
				else
				{
					c[idx] = r[rdx];
					rdx++;
				}
				idx++;
			}

			while (ldx < l.Length)
			{
				c[idx] = l[ldx];
				ldx++;
				idx++;
			}

			while (rdx < r.Length)
			{
				c[idx] = r[rdx];
				rdx++;
				idx++;
			}
		}

		//Copilot generated BozoSort in case you wanna set your computer on fire
		public static void BozoSort(ref T[] c)
		{
			Random rnd = new Random();
			int idx1, idx2;
			while (!IsSorted(c))
			{
				idx1 = rnd.Next(0, c.Length);
				idx2 = rnd.Next(0, c.Length);
				SwapValues(ref c[idx1], ref c[idx2]);
			}
		}

		//Copilot generated IsSorted just for the bozo sort 
		private static bool IsSorted(T[] c)
		{
			for (int i = 0; i < c.Length - 1; i++)
			{
				if (c[i].CompareTo(c[i + 1]) > 0)
				{
					return false;
				}
			}
			return true;
		}

		//swaps and stuff

		private static void SwapValues(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}

	}
}
