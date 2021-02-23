using System;

class MainClass {
  public static void Main (string[] args) {
    string nombres, apellidos, cargo, ganamas = "ganamas", ganamenos = "ganamenos";
    double horastrabajo, bono, excepcion = 0, sueldobase, isss = 0.0525, afp = 0.0688, renta = 0.1, mas300 = 0, sueldoliquido, mayorsalario = 0, menorsalario = 0;

    for(int cont=0; cont<3; cont++){
      Console.WriteLine("Escriba sus nombres");
      nombres = Console.ReadLine();

      Console.WriteLine("Escriba sus apellidos");
      apellidos = Console.ReadLine();

      Console.WriteLine("Escriba su cargo");
      cargo = Console.ReadLine();

      Console.WriteLine("Total de horas trabajadas durante el mes");
      horastrabajo = Double.Parse(Console.ReadLine());

      if(horastrabajo <= 0){
        continue;
      }

      if(cargo == "Gerente"){
        bono = 0.10;
        if(cont == 0){
          excepcion++;
        }
      }else{
        if(cargo == "Asistente"){
          bono = 0.05;
          if(cont == 1){
            excepcion++;
          }
        }else{
          if(cargo == "Secretaria"){
            bono = 0.03;
            if(cont == 2){
              excepcion++;
            }
          }else{
            bono = 0.02;
          }
        }
      }

      if(horastrabajo <= 160){
        sueldobase = horastrabajo * 9.75;
      }else{
        sueldobase = (160 * 9.75) + ((horastrabajo - 160) * 11.50);
      }

      sueldoliquido = sueldobase - ((sueldobase * isss) + (sueldobase * afp) + (sueldobase * renta));

      if(sueldoliquido > 300){
        mas300++;
      }

      if((sueldoliquido + (sueldoliquido * bono)) > mayorsalario){
        mayorsalario = (sueldoliquido + (sueldoliquido * bono));
        ganamas = nombres + " " + apellidos;
      }

      if(menorsalario == 0){
        menorsalario = (sueldoliquido + (sueldoliquido * bono));
        ganamenos = nombres + " " + apellidos;
      }else{
        if((sueldoliquido + (sueldoliquido * bono)) < menorsalario){
          menorsalario = (sueldoliquido + (sueldoliquido * bono));
          ganamenos = nombres + " " + apellidos;
        }
      }

      Console.WriteLine("Nombre del empleado: " + nombres + " " + apellidos);
      Console.WriteLine("Descuentos");
      Console.WriteLine("ISSS = " + (isss*100) + "%");
      Console.WriteLine("AFP = " + (afp*100) + "%");
      Console.WriteLine("RENTA = " + (renta*100) + "%");

      Console.WriteLine("Sueldo líquido a pagar = $" + sueldoliquido);
      Console.WriteLine("Si es apto para bonos = $" + (sueldoliquido + (sueldoliquido * bono)));
    }

    if(excepcion == 3){
      Console.WriteLine("NO HAY BONO");
    }

    Console.WriteLine("Empleado con mayor salario: " + ganamas);
    Console.WriteLine("Empleado con menor salario: " + ganamenos);
    Console.WriteLine("Numero de personas que ganan más de $300 = " + mas300);
  }
}