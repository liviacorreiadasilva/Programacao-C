#include <stdio.h>
#include <stdlib.h>

int main()
{
float n1, n2, media;
printf("digite uma nota: "); scanf("%f",&n1);
printf("digite outra nota: "); scanf("%f",&n2);
media = (n1+n2/2);
if (media >6){
     printf("Aluno aprovado");
}

else
{
    printf("Aluno reprovado");
}

   system("pause");
   }
   
