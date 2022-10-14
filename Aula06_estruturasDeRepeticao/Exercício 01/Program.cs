// Pergunte ao usuário a quantidade de repetições que ele quer

int n = 1, final = 0;
Console.Write("Qual o final da repetição: ");
final = Convert.ToInt32(Console.ReadLine());

// Enquanto
Console.Write("---- While ----");
while(n <=final){
    Console.Write("{0}\n",n);
    n=n+1;
}

// Repita
Console.Write("---- Do ----");
n = 1;
do{
    Console.Write("{0}\n",n);
    n++;
}while (n <=final );