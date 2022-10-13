// Exemplo de condições

int n = 0;

//Decisão SIMPLES
if (n > 0){
    //  VERDADEIRO
    Console.Write("POSITIVO!\n");
}


//Decisão COMPOSTA
if (n > 0){
    //  VERDADEIRO
    Console.Write("POSITIVO!\n");
}else{
    //  FALSO
    Console.Write("NEGATIVO!\n");
}


//Decisão ANINHADA/ENCADEADA (Multiplas perguntas)
if(n > 0){           // 1ª Pergunta
     // VERDADEIRO
    Console.Write("POSITIVO!\n");
}else{              
    if(n < 0){      // 2ª Pergunta
    //  VERDADEIRO
    Console.Write("NEGATIVO!\n");
    }else{
        //FALSO
        Console.Write("NULO!\n");
    }
}


/*

Operadores Aritmeticos

  / 
  *
  +
  -
  %



Operadores Relacionais

  > Maior
  < Menor
  >= Maior ou Igual
  <= Menor ou Igual
  == Igual
  !+ Diferente
  


Operadores Logicos
  
  E            &&
  Ou           ||
  OU Exclusivo  ^



Tabela Verdade (E = &&  OU = || XOR = ^

  P   |   Q   |   E   |  OU  |   OU EXCLUSIVO
-------------------------------------------
  V       V       V      V       F
  F       V       F      V       V 
  V       F       F      V       V 
  F       F       F      F       F 



int dia = 5;

if( dia > 1   &&   < 7 )
if( dia >= 2  &&   <= 6 )
    V               V
 
dia = 6, mes = 10;

if ( dia >= 2 && <=6 )  &&  dia <=7  && mes == 10 )
         V        V              V          V
             V                   V          
                         V                   V           
                                 V
*/

