//precisa converter para tipo númerico porque tudo que o usuário digita é uma string
//exercícios abaixo (plataforma beecrowd)

static void p1001(){
/* Leia dois valores inteiros e armazene-os nas variáveis A e B.
Efetue a soma de A e B atribuindo o seu resultado na variável X. 
Imprima X conforme exemplo abaixo. Não apresente mensagem alguma 
além daquilo que está especificado e não esqueça de imprimir o fim de linha (\n) 
após o resultado.   */

    int a, b, x;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    x = a + b;
    Console.Write("X = {0}\n", x);
}

static void p1002(){
    /* A fórmula para calcular a área de uma circunferência é:
    area = pi*raio². Considerando para este problema que pi=3.14159:
    - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por pi.    */

    double area, raio;
    area = Convert.ToDouble(Console.ReadLine());
    raio = Convert.ToDouble(Console.ReadLine());
    area = 3.14159 * Math.Pow(raio, 2.0); //2.0 porque é tipo double, para não dar erro

    Console.Write("A={0}\n", area.ToString("0.0000"));
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
