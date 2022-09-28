// Algoritmo que imprima todos os anos bissextos de 0 a 2020
//e informar quantos anos bissextos foram impressos.

using System;
class HelloWorld {
  static void Main() {
    
    int anos = 0;
    int quantidaDeBiseextos = 0;
  
    for(anos = 0; anos <= 2020; anos ++) {
        
        if (anos % 4 == 0) {
            Console.WriteLine(anos);
            quantidaDeBiseextos++;
        }
        
       // Se fosse com while anos++;
    }
    
    Console.WriteLine("Numeros de anos bissextos são: " + quantidaDeBiseextos);
    
  }
}