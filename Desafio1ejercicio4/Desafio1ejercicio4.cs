using System;

class MainClass {
  public static void Main (string[] args) {
    Double num1, num2, num3;
    
    num1 = Double.Parse(Console.ReadLine());
    num2 = Double.Parse(Console.ReadLine());
    num3 = Double.Parse(Console.ReadLine());

    if(num1 > num2 && num1 > num3){
      Console.WriteLine(num1);
    }else{
      if(num2 > num3){
        Console.WriteLine(num2);
      }else{
        Console.WriteLine(num3);
      }
    }
  }
}