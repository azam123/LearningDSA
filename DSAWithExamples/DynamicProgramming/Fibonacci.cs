//1. Implementing DP for a Basic Problem: Fibonacci Sequence
//The Fibonacci sequence is a classic problem to demonstrate dynamic programming. The goal is to find the nth Fibonacci number.

//Brute Force Approach
//The brute force approach involves a simple recursive solution without memoization:
public class Fibonacci
{
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return Fib(n - 1) + Fib(n - 2);
    }
}
//Time Complexity: O(2 ^ n)(exponential, due to overlapping subproblems).
//Space Complexity: O(n) (due to the recursion stack).

//Optimized Approach with Memoization
//Memoization involves storing previously computed results to avoid redundant calculations:
using System;
using System.Collections.Generic;

public class Fibonacci1s
{
    private Dictionary<int, int> _memo = new Dictionary<int, int>();

    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        if (_memo.ContainsKey(n))
        {
            return _memo[n];
        }

        _memo[n] = Fib(n - 1) + Fib(n - 2);
        return _memo[n];
    }
}

//Time Complexity: O(n)(due to memoization).
//Space Complexity: O(n)(due to the memoization dictionary and recursion stack).

//Optimized Approach with Iterative Solution
//An iterative solution using dynamic programming:
public class Fibonacci2
{
    public int Fib(int n)
    {
        if (n <= 1) return n;

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}
//Time Complexity: O(n)(due to memoization).
//Space Complexity: O(n) (due to DP array)

