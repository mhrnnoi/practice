namespace practice;
public class SubarrayWithGivenSum
{
    public List<int> subarraySum(int[] arr, int n, int s)
    {
        //Array ro begir
        //sub array ka jamesh barabar ba s hast ro peyda kon
        //var starter  1 + 2 + 3 => starter = 2 + 3 + 4
        //starter for et az starter har bar i barabare ba starter
        // index avalin adad va index akharin add sub array
        // dakhel array asli ro bede
        // agar be javab naresidi -1 bede
        // {1,2,3,7,5}
        //{ 1, 2, 3, 5, 6, 8, 9, 10 }
        var sum = 0;
        var starter = 0;
        var result = new List<int>();
        sum = arr[starter];
        for (int i = starter + 1; starter < n; i++)
        {
            if (starter == n - 1)
            {
                if (sum == s)
                {
                    result.Add(starter);
                    return result;
                }
                starter++;


            }
            else
            {
                sum = arr[i] + sum;
                if (sum == s)
                {
                    result.Add(starter);
                    result.Add(i);
                    return result;

                }
                else if (sum > s)
                {
                    starter++;
                    sum = arr[starter];
                    i = starter;
                }

            }


        }
        if (result.Count() < 2)
        {
            result.Add(-1);
        }
        return result;

    }

}
