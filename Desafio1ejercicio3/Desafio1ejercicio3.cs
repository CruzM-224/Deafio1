using System;

class MainClass {
  public static void Main (string[] args) {
    Double nota1, nota2, nota3, prom;

    nota1 = Double.Parse(Console.ReadLine());
    nota2 = Double.Parse(Console.ReadLine());
    nota3 = Double.Parse(Console.ReadLine());

    prom = (nota1 + nota2 + nota3) / 3;

    if(prom >= 7){
      Console.WriteLine("Promocionado");
    }else{
      if(prom >= 4){
        Console.WriteLine("Regular");
      }else{
        Console.WriteLine("Reprobado");
      }
    }

  }
}