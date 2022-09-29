// Exercícios abaixo (Problemas de lógica-pdf Prof. Daniel)


/*  int a, b, x;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    x = a + b;
    Console.Write("X = {0}\n", x); */

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

static void p1003(){

}

static void p1004(){

}

static void p1005(){

}

static void p1006(){

}

static void p1007(){

}

static void p1008(){

}

static void p1009(){

}

static void p1010(){

}

static void p1011(){

}

static void p1012(){

}

static void p1013(){

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