using System;

class MainClass {
  public static void Main (string[] args) {
    Double precio, cantidad, total;
    
    Console.WriteLine("Ingresar el precio del producto");
    precio = Double.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar la cantidad a comprar");
    cantidad = Double.Parse(Console.ReadLine());

    total = precio * cantidad;
    Console.WriteLine("El total a pagar es: $" + total);
  }
}