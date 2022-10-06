// Exemplo de condições

int n = -100;


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
