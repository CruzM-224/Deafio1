using System;

class MainClass {
  public static void Main (string[] args) {
    Double num1, num2, num3, num4;
    
    Console.WriteLine("Ingrese 4 numeros");

    num1 = Double.Parse(Console.ReadLine());
    num2 = Double.Parse(Console.ReadLine());
    num3 = Double.Parse(Console.ReadLine());
    num4 = Double.Parse(Console.ReadLine());

    Console.WriteLine("La suma de los dos primeros es igual a " + (num1 + num2));
    Console.WriteLine("El producto del tercero y el cuarto es igual a " + (num3 * num4));
  }
}