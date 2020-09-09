using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter a number: ");
    var num1 = Console.ReadLine();
    Console.Write("Enter another number: ");
    var num2 = Console.ReadLine();
    int x = Convert.ToInt32 (num1);
    int y = Convert.ToInt32 (num2);
    // I originally had this under "double" so that decimals could also be utilized in this code. Will further research c# syntax that can make just the quotient section an integer (personal)
    var sum = (x + y);
    Console.WriteLine ("Sum = " + sum);
    var diff = (x - y);
    Console.WriteLine ("Difference = " + diff);
    var product = ( x * y); 
    Console.WriteLine ("Product = " + product);
    var quotient = ( x/y );
    Console.WriteLine ("Quotient = " + quotient);
    var remainder = ( x % y );
    Console.WriteLine ("Remainder = " + remainder);



  

     
  }
}