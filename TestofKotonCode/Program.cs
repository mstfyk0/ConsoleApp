﻿// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");


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

static void findDifference (string str)
{

    Console.WriteLine("Input = " + str);
    char[] chars = str.ToCharArray();
    int arrayIndex=-1;
    for (int i = 0; i < (chars.Length)-1; i++)
    {
        if (arrayIndex == -1)
        {
            for (int j = i + 1; j <= i + 1; j++)
            {
                if (chars[i] != chars[j])
                {
                    arrayIndex = i;

                    Console.WriteLine("Output = " + i);
                }
            }
        }
    }
}

int[] numbers = [1, 3, 5, 7, 9, 13, 15, 17];
int[] numbers2 = [9,7,3];

string str1 = "AAABAB";
string str2 = "AAAAAAAAB";
string str3 = "BB";


returnMissingOdd(numbers);
returnMissingOdd(numbers2);
findDifference(str1);
findDifference(str2);
findDifference(str3);
