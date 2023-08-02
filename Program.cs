using practice;

Console.WriteLine("Example 1 N = 5, S = 12  , A[] = {1,2,3,7,5}");
int n1 = 5, s1 = 12;
var A1 = new int[] { 1, 2, 3, 7, 5 };

SubarrayWithGivenSum q11 = new SubarrayWithGivenSum();
var res1 = q11.subarraySum(A1, n1, s1);

foreach (var item in res1)
{
    Console.WriteLine(item);
}
Console.ReadKey();
///////////////////////////////
Console.WriteLine("Example 2 N = 10, S = 15 , A[] = {1,2,3,4,5,6,7,8,9,10}");

int n2 = 10, s2 = 15;
var A2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

SubarrayWithGivenSum q12 = new SubarrayWithGivenSum();
var res2 = q12.subarraySum(A2, n2, s2);

foreach (var item in res2)
{
    Console.WriteLine(item);
}
Console.ReadKey();
///////////////////////////////
Console.WriteLine("Example 3 N = 8, S = 7 , A[] = { 1, 2, 3, 5, 6, 8, 9, 10 }");

int n3 = 8, s3 = 7;
var A3 = new int[] { 1, 2, 3, 5, 6, 8, 9, 10 };

SubarrayWithGivenSum q13 = new SubarrayWithGivenSum();
var res3 = q13.subarraySum(A3, n3, s3);

foreach (var item in res3)
{
    Console.WriteLine(item);
}
Console.ReadKey();
///////////////////////////////
Console.WriteLine("Example 4 N = 42, S = 468 , A[] = { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146 ,82 ,28, 162, 92 ,196, 143, 28 ,37 ,192, 5 ,103, 154, 93 ,183 ,22, 117 ,119, 96, 48, 127, 172, 139, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 }");
int n4 = 42, s4 = 468;
var A4 = new int[] { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146, 82, 28, 162, 92, 196, 143, 28, 37, 192, 5, 103, 154, 93, 183, 22, 117, 119, 96, 48, 127, 172, 139, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 };
SubarrayWithGivenSum q14 = new SubarrayWithGivenSum();
var res4 = q14.subarraySum(A4, n4, s4);

foreach (var item in res4)
{
    Console.WriteLine(item);
}
Console.ReadKey();