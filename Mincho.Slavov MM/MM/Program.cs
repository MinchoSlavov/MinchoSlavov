using System;
using System.Text;

public class Task
{
	public static void safedel(StringBuilder sb, int end)
	{
		if (sb.Length >= end)
		{
			sb.Remove(0, end);
		}
		else sb.Remove(0, sb.Length);

	}

	public static void generateFirstHalf(int rows)
	{
		StringBuilder lines = new StringBuilder();
		StringBuilder midLines = new StringBuilder();
		StringBuilder midStars = new StringBuilder();
		StringBuilder stars = new StringBuilder();
		StringBuilder printed = new StringBuilder();
		String twoStars = "**";
		String twoLines = "--";
		for (int i = 0; i < rows; i++)
		{
			lines.Append("-");
			stars.Append("*");
			midLines.Append("-");
		}

		int row;
		for (row = 0; row < (rows + 1) / 2; row++)
		{
			for (int i = 0; i < 2; i++)
			{
				printed.Append(lines).Append(stars).Append(midLines).Append(stars).Append(lines);
			}

			printed.Append("\n");
			safedel(lines, 1);
			safedel(midLines, 2);
			stars.Append(twoStars);
		}

		midLines.Append('-');
		safedel(stars, stars.Length);
		stars.Append('*', rows);
		midStars.Append('*', rows * 2 - 1);
		for (; row <= rows; row++)
		{
			for (int i = 0; i < 2; i++)
			{
				printed.Append(lines).Append(stars).Append(midLines).Append(midStars).Append(midLines).Append(stars).Append(lines);
			}

			printed.Append("\n");
			safedel(lines, 1);
			midLines.Append(twoLines);
			safedel(midStars, 2);
		}

		Console.WriteLine(printed.ToString());
	}

	public static void Main()
	{
		Console.WriteLine("Enter value for N: ");
		var n= Console.ReadLine();

		while (!int.TryParse(n,out _) || Convert.ToInt32(n) % 2 == 0 || Convert.ToInt32(n) < 2 || Convert.ToInt32(n) > 10000)
		{ 
			Console.WriteLine("Please enter an odd number between 2 and 10 000");
			n = Console.ReadLine();
		}
		Console.WriteLine("N= " + n);
		generateFirstHalf(Convert.ToInt32(n));
		
		/*Console.WriteLine("Please enter value for N: ");
		var n = (Console.ReadLine());
		bool IsNum = int.TryParse(n, out _);
		if (!IsNum)
		{
			Console.WriteLine("Please enter a number");
		}
		else if (Convert.ToInt32(n) % 2 == 0 || Convert.ToInt32(n) < 2 || Convert.ToInt32(n) > 10000)
		{
			Console.WriteLine("Must be an odd number between 2 and 10 000");
		}
		else
		{
			Console.WriteLine("N = " + n);
			generateFirstHalf(Convert.ToInt32(n));
		}*/
	}
}