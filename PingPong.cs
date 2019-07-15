using System;
using System.IO;
class PingPong
{
  static void Main()
  {
    Console.WriteLine ("Enter your number:");
    string stringNum = Console.ReadLine();
    int yourNumber=int.Parse(stringNum);
    int[] numbersArray = new int[yourNumber];


    for (int i =1; i<= yourNumber ; i++)
    {
      numbersArray[i - 1] = i;
    }
string[] result = Array.ConvertAll(numbersArray, x=>x.ToString());

    for (int i= 0; i<yourNumber; i++)
    {
    if (numbersArray[i]%3==0){
      result[i]= "Ping";
    }
    if (numbersArray[i]%5==0){
      result[i]= "Pong";
    }
    if (numbersArray[i]%3==0 && numbersArray[i]%5==0){
      result[i]= "Ping-Pong";
    }
  }
  Console.WriteLine("Array line : "+ string.Join(",", result));
}
}
