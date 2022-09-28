using System;
class HelloWorld {
  static void Main() {
 
   int resultado = 0;
   
   for (int multplicador = 1; multplicador <= 10; multplicador++) {
       for(int multplicando = 1; multplicando <=10; multplicando++) {
           resultado = multplicador * multplicando;
           
           Console.WriteLine($"{multplicador} x {multplicando} = {resultado}");
       }
   }
   
   
  }
}