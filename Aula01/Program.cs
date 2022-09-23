// Variável = espaço reservado na memória do computador.
//writeline pula linha
// int = inteiro
/*short a = 0215;

// double ou decimal = real
double salario = 1000.50;

// string = caracteres 
string nome = "Rebeca";

// true(1) ou false (0)
bool aula = true;

// Para escrever na tela = Console.Write("String");
//Console.WriteLine("Hello, World!");

// Para ler um valor = Console.ReadLine();
Console.WriteLine("a = " + a);
Console.WriteLine("Salario = " + salario);
Console.WriteLine("Nome = " + nome);
Console.WriteLine("Estamos em aula? " + aula);
*/

//Leia duas variáveis do tipo inteiro, realize a soma e exiba o resultado na tela.
int a, b, soma;
Console.Write("Digite o valor de a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de b: ");
b = Convert.ToInt32(Console.ReadLine());

soma = a + b;
Console.Write("Soma = "+soma+"\n");