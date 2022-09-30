// Exercícios abaixo (Problemas de lógica-pdf Prof. Daniel)

static void p1001(){    //sz
// 1 - Crie um programa para exibir o seu nome.
   
    Console.Write("Rebeca Feitosa");
}

static void p1002(){    //sz
// 2 - Crie um programa que some dois números.
    
    int a, b, soma;
    Console.Write("Digite um valor: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite outro valor: ");
    b = Convert.ToInt32(Console.ReadLine());
    soma = a + b;
    Console.Write("A soma dois dois números é: "+soma);
}

static void p1003(){    //sz
// 3 - Crie um programa que solicite duas notas e calcule a média do aluno.
    
    double nota1, nota2, media;
    Console.Write("Digite sua primeira nota: ");
    nota1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite sua segunda nota: ");
    nota2 = Convert.ToDouble(Console.ReadLine());
    media = (nota1 + nota2)/2;
    Console.Write("Sua média é: "+media);
}

static void p1004(){    //sz
/*  4 - Crie um programa que solicite duas notas do aluno, calcule a média 
e informe se o aluno está "aprovado" ou "reprovado" (média 6.0) */
    
    double nota1, nota2, media;
    Console.Write("Digite sua primeira nota: ");
    nota1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite sua segunda nota: ");
    nota2 = Convert.ToDouble(Console.ReadLine());
    media = (nota1 + nota2)/2;

    if (media>=6){
        Console.Write("Sua média é: "+media+"\nVocê foi aprovado!");
    }else{
        Console.Write("Sua média é: "+media+"\n"+"Você foi reprovado!");
    }
}

static void p1005(){
/* 5 - Crie um programa que solicite 3 notas do aluno (Av1, Av2, Av3), 
descarte a menor nota e exiba a média do aluno, informando se o mesmo 
foi aprovado ou não. */
   
}

static void p1006(){    //sz
// 6 - Crie um programa que solicita um número e informa se ele é positivo ou negativo. 
    
    double numero;
    Console.Write("Digite um número: ");
    numero = Convert.ToDouble(Console.ReadLine());

    if (numero>=0){
        Console.Write("O número que você digitou é positivo!");
    }else{
        Console.Write("O número que você digitou é negativo!");
    }
}

static void p1007(){    //sz
// 7 - Crie um programa que solicita o ano de nascimento do usuário e informe a sua idade.
    
    int ano, idade;
    Console.Write("Digite o seu ano de nascimento: ");
    ano = Convert.ToInt32(Console.ReadLine());
    idade = 2022 - ano;
    Console.Write("Sua idade é: "+idade);
}

static void p1008(){    //sz
// 8 - Crie um programa que solicita a sua idade e informe o seu ano de nascimento.
    
    int ano, idade;
    Console.Write("Digite o sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
    ano = 2022 - idade;
    Console.Write("Você nasceu em "+ano);
}

static void p1009(){
/* 9 - Crie um programa que solicita um valor ao usuário (idade ou ano de nascimento) 
e informe a sua idade ou a sua data de nascimento. */

}

static void p1010(){    //sz
// 10 - Criar um programa que solicite um numero do usuário e diga se ele é par ou ímpar.

    double numero;
    Console.Write("Digite um número: ");
    numero = Convert.ToDouble(Console.ReadLine());

    if (numero % 2 == 0){
        Console.Write("O número que você digitou é par!");
    }else{
        Console.Write("O número que você digitou é ímpar!");
    }
}

static void p1011(){

}

static void p1012(){

}

static void p1013(){    //sz
// 13 - Crie um programa que solicita um valor em metros e converta para centímetros.

    double metros, centimetros;
    Console.Write("Digite um valor em metros: ");
    metros = Convert.ToDouble(Console.ReadLine());
    centimetros = metros / 100;
    Console.Write("O valor em cm é: "+centimetros);
    
}

int prog;
    Console.Clear(); //limpar a tela

do{
        Console.Write("\n\nGerenciador de programas: ");
        Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
        prog = Convert.ToInt32(Console.ReadLine());

        switch( prog ){ 
            case 1001:  p1001();    break;
            case 1002:  p1002();    break;
            case 1003:  p1003();    break;
            case 1004:  p1004();    break;
            case 1005:  p1005();    break;
            case 1006:  p1006();    break;
            case 1007:  p1007();    break;
            case 1008:  p1008();    break;
            case 1009:  p1009();    break;
            case 1010:  p1010();    break;
            case 1011:  p1011();    break;
            case 1012:  p1012();    break;
            case 1013:  p1013();    break;
            case 0:     Console.Write("\nObrigada por utilizar nosso Software\n");    break;
            default:    Console.Write("\nOpção Inválida\n");    break;
        }   /*se não colocar o break na frente de cada um, 
            ele vai rodar 1001, depois 1002 assim sucessivamente */

} while( prog != 0 );