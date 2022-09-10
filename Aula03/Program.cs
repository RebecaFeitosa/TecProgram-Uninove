/*precisa converter para tipo númerico porque tudo que o usuário digita é uma string
readline le tudo que está na linha até dar enter
exercícios abaixo (plataforma beecrowd) */

static void p1001(){
/* Leia dois valores inteiros e armazene-os nas variáveis A e B.
Efetue a soma de A e B atribuindo o seu resultado na variável X. */

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
/* Leia dois valores inteiros A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. 
A seguir escrever o valor desta variável. */

    int a, b, soma;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    soma = a + b;

    Console.Write("SOMA = {0}\n", soma);
}

static void p1004(){    //sz
/* Leia os valores inteiros. A seguir, calcule o produto entre estes dois valores e
atribua esta operação à variável PROD. */

    int a, b, prod;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    prod = a * b;

    Console.Write("PROD = {0}\n", prod);
} 

static void p1005(){
/* Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas
de um aluno. A seguir, calcule a média do aluno sabendo que a nota A tem peso 3.5 e a nota B
tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. */

    double a, b, media;
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    media = (a*3.5 + b*7.5) / (3.5 + 7.5);

    Console.Write("MEDIA = {0}\n", media.ToString("0.00000"));
}

static void p1006(){    //sz
/* Leia 3 valores, A, B e C, que são três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, 
a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir até 10.0, sempre com uma casa decimal. */
    double a, b, c, media;
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    c = Convert.ToDouble(Console.ReadLine());
    media = (a * 2) + (b * 3) + (c * 5)/ (2 + 3 + 5);

    Console.Write("MEDIA = {0}\n", media.ToString("0.0"));
} 

static void p1007(){    //sz
/* Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A pelo
produto de C e D segundo a fórmula: DIFERENCA = (A*B-C*D) */

    int a, b, c, d, diferenca;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    d = Convert.ToInt32(Console.ReadLine());
    diferenca = (a*b) - (c*d);

    Console.Write("DIFERENCA = {0}", diferenca);
}

static void p1008(){    //sz
/* Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que
recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário,
com duas casas decimais */

    double funcionario, horas_trabalhadas, valor_hora, salario;
    funcionario = Convert.ToDouble(Console.ReadLine());
    horas_trabalhadas = Convert.ToDouble(Console.ReadLine());
    valor_hora = Convert.ToDouble(Console.ReadLine());
    salario = horas_trabalhadas * valor_hora;

    Console.Write("NUMBER = {0}\nSALARY = U$ {1}", funcionario, salario.ToString("0.00"));
} 

static void p1009(){    //sz
/* Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês
(em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informe o total a receber no
final do mês, com duas casas decimais */

    string nome;
    double salario_fixo, total_vendas, salario_final;
    nome = Console.ReadLine();
    salario_fixo = Convert.ToDouble(Console.ReadLine());
    total_vendas = Convert.ToDouble(Console.ReadLine());
    salario_final = (total_vendas * 0.15) + salario_fixo;

    Console.Write("TOTAL = R$ {0}\n", salario_final.ToString("0.00"));
} 

static void p1010(){
/* Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor
a ser pago. */

    int cod1, quant1, cod2, quant2;
    double preco1, preco2, valor_total;
    string linha1, linha2;

    linha1 = Console.ReadLine();
    linha2 = Console.ReadLine();
    
    //VALORES DA PRIMEIRA LINHA
    string[] vetor = linha1.Split(' '); 
    //split= separador, toda vez que entrar um espaço em branco vai colocar uma posição(índice) do vetor
    cod1 = Convert.ToInt32(vetor[0]);
    quant1 = Convert.ToInt32(vetor[1]);
    preco1 = Convert.ToDouble(vetor[2]);

    //VALORES DA SEGUNDA LINHA
    vetor = linha2.Split(' ');
    cod2 = Convert.ToInt32(vetor[0]);
    quant2 = Convert.ToInt32(vetor[1]);
    preco2 = Convert.ToDouble(vetor[2]);

    //CÁLCULO
    valor_total = (quant1 + preco1) + (quant2 *preco2);

    Console.Write("VALOR A PAGAR: R$ {0}\n", valor_total.ToString("0.00"));
}

static void p1011(){}

static void p1012(){}

static void p1013(){    //sz, duvida
/* Faça um programa que leia três valores e apresente o maior dos três valores lidos
seguido da mensagem "eh o maior". Utilize a fórmula MaiorAB= (a+b+abs(a-b))/2     */
    
    string linha;
    int a, b, c, maiorAB;

    linha = Console.ReadLine();
    string[] vetor = linha.Split(' ');

    a = Convert.ToInt32(vetor[0]);
    b = Convert.ToInt32(vetor[1]);
    c = Convert.ToInt32(vetor[2]);
    maiorAB = (a+b+c+Math.Abs(a-b-c))/2;

    Console.Write("{0} eh o maior", maiorAB);
}

static void p1014(){    //sz
/* Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km)
e o total de combustível gasto (em litros) */

    double distancia, combustivel, consumo;
    distancia = Convert.ToDouble(Console.ReadLine());
    combustivel = Convert.ToDouble(Console.ReadLine());
    consumo = distancia/combustivel;

    Console.Write("{0} Km/l\n", consumo.ToString("0.000"));
}

static void p1015(){}

static void p1016(){}

static void p1017(){}

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
            case 1014:  p1014();    break;
            case 1015:  p1015();    break;
            case 1016:  p1016();    break;
            case 1017:  p1017();    break;
            case 0:     Console.Write("\nObrigada por utilizar nosso Software\n");    break;
            default:    Console.Write("\nOpção Inválida\n");    break;
        }   /*se não colocar o break na frente de cada um, 
            ele vai rodar 1001, depois 1002 assim sucessivamente */

} while( prog != 0 );
