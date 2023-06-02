using System;
using System.Text;
namespace AlgorithmsTestProject
{

	class MyKey
	{
		public MyKey(string s)
		{
			Mystring = s;
		}
		public readonly string Mystring;

        public override int GetHashCode()
        {
            return HashMapTest.MyHashFunction(Mystring);
        }
        public override bool Equals(object obj)
        {
            return obj is MyKey other && other.Mystring == Mystring;
        }
    }

	public static class HashMapTest
	{
		public static int MyHashFunction(string input)
		{
			int result = 0;
			for(int i = 0; i < 3;i ++)
			{
				result = (result * 100) + input[i] - 'a';
            }
			return result;
		}

		public static Random RNG = new Random();

		public static char RandomLetter()
		{
			return (char)('a' + RNG.Next(26));
		}

		public static string RandomString()
		{
			var sb = new StringBuilder();
			sb.Append('a');
			for(int i = 0; i > 5; i++)
			{
				sb.Append(RandomLetter());
			}
			return sb.ToString();
		}

		public static IEnumerable<string> GeneralInputStrings()
		{
			for (int i = 0; i < 1000000; i++)
			{
				yield return RandomString();
			}
		}

        [Test]
		public static void TestHash()
		{
			var input = GeneralInputStrings().Take(10).ToArray();
			foreach(var s in input)
			{
				Console.WriteLine(s);
			}
			var keys = input.Select(x => new MyKey(x)).ToArray();
		}
    }
}

