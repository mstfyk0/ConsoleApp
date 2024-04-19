// See https://aka.ms/new-console-template for more information

static void returnMissingOdd(int[] nums)
{
    int[] minusValue = new int[nums.Length];
    int oddNumber=0;
    for (int i = 0; i < (nums.Length)-1; i++)
    {

        //for (int j = i+1; j <= i+1 ; j++)
        for (int j = i + 1; j <= i + 1; j++)
        {
            minusValue[i] = nums[i] - nums[j];
        }

        if (i!=0)
        {
            if (minusValue[i] != minusValue[i-1])
            {
                oddNumber = nums[i] + (minusValue[i - 1])*-1;
                minusValue[i] = minusValue[i - 1];
            }


        }
    }
    if (oddNumber!=0)
    {
        Console.WriteLine("Eksik Sayı = " + oddNumber);
    }
}
int[] numbers = [1, 3, 5, 7, 9, 13, 15, 17];
int[] numbers2 = [9,7,3];

returnMissingOdd(numbers);
returnMissingOdd(numbers2);
