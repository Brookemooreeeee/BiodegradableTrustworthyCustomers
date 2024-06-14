using System;
using System.Collections.Generic;

class Program 
{
   static void Main (string[] args) 
  {
    //List hold all found perfect numbers between 1 & 10,000
    List<int> perfectNumbers = new List<int>();
    for (int i = 1; i <= 10000; i++)
    {
      if (IsPerfectNumber(i))
      {
        perfectNumbers.Add(i);
      }
    }
    
    //Displays all found perfect numbers
    Console.WriteLine("All perfect numbers between 1 and 10,000:");
    foreach (int number in perfectNumbers)
    {
      Console.WriteLine(number);
    }
    
    //Checks and displays if unit test # is a perfect number
    int testNumber = 496;
    Console.WriteLine(); //Empty line for separation
    if (perfectNumbers.Contains(testNumber))
    {
      Console.WriteLine($"{testNumber} is a perfect number.");
    }
    else
    {
      Console.WriteLine($"{testNumber} is not a perfect number.");
    }
  }
  
  //Method for finding perfect numbers
  static bool IsPerfectNumber(int number)
  {
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
      if (number % i == 0)
      {
        sum += i;
      }
    }
     return sum == number; 
  }
}