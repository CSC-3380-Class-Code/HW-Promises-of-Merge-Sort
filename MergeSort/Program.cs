namespace MergeSort;

using System.Threading.Tasks;

class MergeSort {

    static List<int> Merge(List<int> left, List<int> right){

        List<int> result = new List<int>();
        int i =0, j = 0;

        while (i < left.Count && j < right.Count) {
            if (left[i] <= right[j]) {
                result.Add(left[i]);
                i++;
            }
            else {
                result.Add(right[j]);
                j++;
            }
        }

        while (i < left.Count) {
            result.Add(left[i]);
            i++;
        }

        while (j < right.Count) {
            result.Add(right[j]);
            j++;
        }

        return result;
    }

    public static List<int> SortSynchronous(List<int> arr)
    {

        if (arr.Count < 2) {
            return arr;
        }

        int middle = arr.Count / 2;

        List<int> left = SortSynchronous(arr.Take(middle).ToList());
        List<int> right = SortSynchronous(arr.Skip(middle).ToList());

        return Merge(left, right);

    }

	public static List<int> SortPromise(List<int> arr)
    {
        throw new NotImplementedException();

    }

    public static void Main(){}
}
