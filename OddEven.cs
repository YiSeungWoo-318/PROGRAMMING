// See https://aka.ms/new-console-template for more information

using System;
public class Solution
{
    public string solution(int num)
    {   
        int a = num;
        int b = 2;
        double remain = a % b;
        if (remain == 0)
            return "Even";
        else
            return "Odd";

    }
}