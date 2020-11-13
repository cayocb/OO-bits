
#include <stdio.h>

int main( void )
{
  unsigned int a;

  asm volatile (
      "cpuid"
      : "=a"
      : "0"
      : "%rbx", "%rcx", "%rdx"
  );

  printf( "Tamanho do endereço físico: (in bits): %u\n"
          "Tamanho do endereço linear: (in bits): %u\n",
          a & 0xff, (a >> 8) & 0xff );
}


# Ordenação e organização de bits
 
 # Creditos (H4) e outras fontes.
