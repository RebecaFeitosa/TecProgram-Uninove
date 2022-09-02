//precisa converter para tipo númerico porque tudo que o usuário digita é uma string
//exercícios abaixo (plataforma beecrowd)

static void p1001(){
/* Leia dois valores inteiros e armazene-os nas variáveis A e B.
Efetue a soma de A e B atribuindo o seu resultado na variável X. 
Imprima "X = ". Não apresente mensagem alguma além daquilo que 
está especificado e não esqueça de imprimir o fim de linha (\n) após o resultado.   */

    int a, b, x;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    x = a + b;
    Console.Write("X = {0}\n", x);
}

static void p1002(){
    /* A fórmula para calcular a área de uma circunferência é:
    area = pi*raio². Considerando para este problema que pi=3.14159:
    - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por pi.
    - Imprima "A=" com 4 dígitos após o ponto decimal.    */

    double area, raio;
    area = Convert.ToDouble(Console.ReadLine());
    raio = Convert.ToDouble(Console.ReadLine());
    area = 3.14159 * Math.Pow(raio, 2.0); //2.0 porque é tipo double, para não dar erro

    Console.Write("A={0}\n", area.ToString("0.0000")); 
    /*o ToString delimitou quantas casas decimais eu quero antes 
    e depois da vírgula --> Nesse caso, 0.0000 uma casa antes e 4 depois.   */

}

static void p1003(){
    /* Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule
    a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável. 
    - Imprima a mensagem "SOMA = "  */

    int a, b, soma;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    soma = a + b;

    Console.Write("SOMA = {0}\n", soma);
}

static void p1005(){
    /* Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas
    de um aluno. A seguir, calcule a média do aluno sabendo que a nota A tem peso 3.5 e a nota B
    tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
    - Imprima a mensagem "MEDIA = " com 5 dígitos após o ponto decimal. */
    double a, b, media;
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    media = (a*3.5 + b*7.5) / (3.5 + 7.5);

    Console.Write("MEDIA = {0}\n", media.ToString("0.00000"));
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
            case 1005:  p1005();    break;
            case 0:     Console.Write("\nObrigada por utilizar nosso Software\n");    break;
            default:    Console.Write("\nOpção Inválida\n");    break;
        }   /*se não colocar o break na frente de cada um, 
            ele vai rodar 1001, depois 1002 assim sucessivamente */

} while( prog != 0 );
