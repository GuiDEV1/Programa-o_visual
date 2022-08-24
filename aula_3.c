/*
Programa que captura duas notas divide por 2.
feito em 23/08/2022
versão 1.0
autor: Guilherme M. dias

 */
 

#include <stdio.h>

int main()
{
	float av1, av2, m;
	
	printf("Digite a nota da av1:\n");
	
	scanf("%f", &av1);
	
	printf("Digite a nota da av2:\n");
	
	scanf("%f", &av2);
	
	m = av1 + av2;
	
	printf("%.1f", m /2);
	
	

	return 0;
}
	
	
	
	
	
   
