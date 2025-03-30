namespace MergeSort;

[TestFixture]
public class SortTested{

	private static void PopulateArray(List<int> arr, Random rng){
            for(int i = 0; i < arr.Capacity; i++){
                    arr.Add(rng.Next(1,10000));
            }
        }

    private static bool ArrayEquality(List<int> arr1, List<int> arr2){
        if (arr1.Count != arr2.Count)
            return false;

        for(int i = 0; i < arr1.Count; i++){
            if(arr1[i] != arr2[i])
                return false;
        }

        return true;
    }

	private static bool IsSorted(List<int> arr){
		for(int i = 0; i < arr.Count - 1; i++){
			if(arr[i] > arr[i+1]){
				return false;
			}
		}
		return true;
	}

	[TestCase(10000)]
	[TestCase(50000)]
	[TestCase(100000)]
	[TestCase(500000)]
	public void TestSort(int arrSize){
		Random rng = new Random();
		const int NUM_RUNS = 50;
		double sumImprovement = 0.0;
		int timesImproved = 0;

		for(int i = 0; i < NUM_RUNS; i++){
			List<int> arr = new List<int>(arrSize);
			PopulateArray(arr, rng);

			var watch = System.Diagnostics.Stopwatch.StartNew();
			List<int> sorted1 = MergeSort.SortSynchronous(arr);
			watch.Stop();
			long seqMS = watch.ElapsedMilliseconds;

			watch = System.Diagnostics.Stopwatch.StartNew();
			List<int> sorted2 = MergeSort.SortPromise(arr);
			watch.Stop();
			long promMS = watch.ElapsedMilliseconds;

			Assert.True(IsSorted(sorted2));
			Assert.True(ArrayEquality(sorted1, sorted2));

			timesImproved += (double)promMS/seqMS*100 < 100.0 ? 1 : 0;
			sumImprovement += (double)promMS/seqMS*100;
		}

		Console.WriteLine($"Average Improvement was {sumImprovement/NUM_RUNS} %");
		Console.WriteLine($"Number of Improvements was {timesImproved}");
		Assert.True(timesImproved > NUM_RUNS-10);
		Assert.True(sumImprovement/NUM_RUNS < 70.0);
	}
}