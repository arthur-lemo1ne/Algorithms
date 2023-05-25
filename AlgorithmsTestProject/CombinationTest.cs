using System;
namespace AlgorithmsTestProject
{
	public static class CombinationTest
	{

		/*public static bool DoesOutputSetContain(List<List<int>> outputset, List<int> member)
		{
			foreach (var output in outputset)
			{
				/*if (AreSetsTheSame(output, member))
				{
					return true;
				}
			}
		}*/

        [Test]
		public static void OutputResult()
		{
            var testInput = new[] { 1, 3, 5 };
            var output = GenerateCombination(testInput);
			foreach (var xs in output)
			{
				Console.WriteLine("{"+string.Join(",", xs)+"}");
			}
        }

        [Test]
		public static void TestGenerateCombination()
		{
			var testInput = new[] { 1, 3, 5 };
			var output = GenerateCombination(testInput);

			Assert.AreEqual(8, output.Count);
			var expectedresult = new List<List<int>>
			{
				new List<int> {},
				new List<int> {1},
				new List<int> {3},
				new List<int> {5},
				new List<int> {1,3},
				new List<int> {1,5},
				new List<int> {3,5},
				new List<int> {1,3,5}
			};

			foreach (var expected in expectedresult)
			{
				//Assert.IsTrue(DoesOutputSetContain(expected, ));
			}
        }

        public static List<List<int>> GenerateCombination(int[] input)
		{
			List<List<int>> result = new List<List<int>> { };
			result.Add(new List<int> { });

			int maxLengh = input.Length;
            List<int> cu = new List<int>();


            for (int currentLengh = 1; currentLengh <= maxLengh; currentLengh++)
			{
				for (int repetition = maxLengh; repetition > 0; repetition--)
				{
					cu.Clear();
					for (int i = 0; i < currentLengh; i++)
					{
						cu.Add(input[i]);
						Console.WriteLine(cu);
					}
                    result.Add(cu);

                }
                

            }
			


            return result;
		}
	}
}

