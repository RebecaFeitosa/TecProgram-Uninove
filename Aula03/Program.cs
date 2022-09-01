//dois blocos de programação
static void p1001(){
Console.Write("Prog 1");
}
static void p1002(){
    Console.Write("Prog 2");
}

static void p1003(){
    Console.Write("Prog 3");
}

    int prog;
    Console.Clear(); //limpar a tela

    do{
        Console.Write("\nGerenciador de programas: ");
        Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
        prog = Convert.ToInt32(Console.ReadLine());

        switch( prog ){ 
            case 1001:  p1001();    break;
            case 1002:  p1002();    break;
            case 1003:  p1003();    break;
            case 0:     Console.Write("\nObrigada por utilizar nosso Software\n");    break;
            default:    Console.Write("\nOpção Inválida\n");    break;
        }   /*se não colocar o break na frente de cada um, 
            ele vai rodar 1001, depois 1002 assim sucessivamente */

} while( prog != 0 );
