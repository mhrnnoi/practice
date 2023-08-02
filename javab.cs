//Back-end complete function Template for csharp
namespace practice;
    public class Solution
    {
        //Function to find a continuous sub-array which adds up to a given number.
        public List<int> subarraySum(int[] arr, int n, int s)
        {
            int last=0;
            int start=0;
            long  currsum=0;
            bool flag=false;
            List<int>res = new List<int>();
            
            //iterating over the array.
            for(int i=0;i<n;i++)
            {
                //storing sum upto current element.
                currsum += arr[i];
                
                //checking if current sum is greater than or equal to given number.
                if(currsum>=s)
                {
                    last=i;
                    //we start from starting index till current index and do the 
                    //excluding part while s(given number) < currsum.
                    while(s<currsum && start<last)
                    {
                        //subtracting the element from left i.e., arr[start]
                        currsum -= arr[start];
                        ++start;
                    }
                    
                    //now if current sum becomes equal to given number, we store 
                    //the starting and ending index for the subarray.
                    if(currsum==s)
                    {
                        res.Add(start + 1);
                        res.Add(last + 1);
                        
                        //flag is set to true since subarray exists.
                        flag = true;
                        break;
                    }
                }
            }
            //if no subarray is found, we store -1 in result.
            if(flag==false)
                res.Add(-1);
                
            //returning the result.
            return res;
        }

    }

