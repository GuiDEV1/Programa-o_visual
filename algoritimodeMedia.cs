using System;
class HelloWorld {
  static void Main() {
   
   /* verificar  a média de duas notas do aluno se foi aprovado! */
   
   double n1,n2,media;
   
  
  Console.Write("Digite a nota da av1: ");
  n1 = Convert.ToDouble(Console.ReadLine());
  
  Console.Write("Digite a nota da av2: ");
  n2 = Convert.ToDouble(Console.ReadLine());
  
  media = (n1 + n2) / 2;
  
  if (media >= 6) {
     Console.Write($"Aluno foi aprovado com a média: {media}"); 
  }
  
  else {
      Console.Write($"Aluno reprovado com a média: {media} ");
  }